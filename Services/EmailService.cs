using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using MimeKit;
using PMApplication.Dtos;
using PMApplication.Entities;
using PMApplication.Entities.PlanogramAggregate;
using PMApplication.Enums;
using PMApplication.Interfaces.ServiceInterfaces;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using PMApplication.Interfaces.RepositoryInterfaces;

namespace PMApplication.Services
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _configuration;
        private readonly IEmailRepository _emailRepository;
        private readonly ILogger<EmailService> _logger;
        public EmailService(IConfiguration configuration, IEmailRepository emailRepository, ILogger<EmailService> logger)
        {
            _configuration = configuration;
            _emailRepository = emailRepository;
            _logger = logger;   
        }
        public async Task SendEmailAsync(Email email)
        {
            try
            {
                var emailTemplate = "";
                var emailSubject = email.EmailSubject;

                Brand brand;

                switch (email.EmailTrigger)
                {
                    case (int)EmailTrigger.PlanogramSubmitted:
                        emailTemplate = "PlanogramSubmitted";
                        email.EmailSubject = email.EmailSubject + ": " + email.BrandName + " - " + email.PlanogramName;
                        break;
                    case (int)EmailTrigger.ContactForm:
                        emailTemplate = "ContactForm";
                        break;
                    //case (int)EmailTrigger.AdminOrderSubmitted:
                    //    email.Order = _orderService.GetOrder(email.OrderId);
                    //    brand = _brandService.GetBrand(email.Order.BrandId);
                    //    email.BrandName = brand.BrandName;
                    //    emailSubject = email.EmailSubject + ": " + email.BrandName + " - " + email.Order.OrderTitle;
                    //    emailTemplate = "AdminOrderSubmitted";
                    //    break;
                    //case (int)EmailTrigger.UserOrderSubmitted:
                    //    email.Order = _orderService.GetOrder(email.OrderId);
                    //    emailSubject = email.EmailSubject + ": " + email.Order.OrderTitle;
                    //    emailTemplate = "UserOrderSubmitted";
                    //    break;

                }

                var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

                var contentRoot = _configuration.GetValue<string>(WebHostDefaults.ContentRootKey);
                var builder = new BodyBuilder();
                string template = File.ReadAllText(
                    Path.Combine(contentRoot, "Views", "Email", emailTemplate + ".cshtml"));



                //string htmlTemplate = "";
                //using (StreamReader SourceReader = System.IO.File.OpenText(Path.Combine(baseDirectory, "Views", "Email", emailTemplate + ".cshtml")))
                //{
                //    htmlTemplate = SourceReader.ReadToEnd();
                //}


                //var emailBody = Razor.Parse<Email>(template, email);
                //var EmailSubject = Razor.Parse(email.EmailSubject);

                email.RecipientName = _configuration["EmailSettings:RecipientName"];
                email.BccList = _configuration["EmailSettings:BccList"];
                email.CcList = _configuration["EmailSettings:CcList"];
                email.FromAddress = _configuration["EmailSettings:FromAddress"];
                email.ToAddress = _configuration["EmailSettings:ToAddress"];
                email.EmailEnabled = bool.Parse(_configuration["EmailSettings:EmailEnabled"]);

                string messageBody = string.Format(template, email.RecipientName,
                    email.FirstName + " " + email.LastName, email.PlanogramName, email.CountryName, email.BrandName);

                builder.HtmlBody = messageBody;

                var emailMessage = new MimeMessage();
                emailMessage.From.Add(new MailboxAddress(_configuration["SmtpSettings:SenderName"],
                    _configuration["SmtpSettings:SenderEmail"]));
                emailMessage.To.Add(new MailboxAddress("", email.ToAddress));
                emailMessage.Subject = email.EmailSubject;
                emailMessage.Body = builder.ToMessageBody();
                using (var client = new SmtpClient())
                {
                    await client.ConnectAsync(_configuration["SmtpSettings:Server"],
                        int.Parse(_configuration["SmtpSettings:Port"]), MailKit.Security.SecureSocketOptions.StartTls);
                    await client.AuthenticateAsync(_configuration["SmtpSettings:Username"],
                        _configuration["SmtpSettings:Password"]);
                    await client.SendAsync(emailMessage);
                    await client.DisconnectAsync(true);
                }
                email.DateSent = DateTime.Now;
                await _emailRepository.AddAsync(email);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while sending an email.");
                await _emailRepository.AddAsync(email);

                throw;
            }
            finally
            {
            }
        }
    }
}
