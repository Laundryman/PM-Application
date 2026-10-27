using Azure.Core;
using Azure.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Graph;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Text;
using PMApplication.Entities;

namespace PMApplication.Services
{
    public class GraphService
    {
        private readonly ILogger<JobFolderService> _logger;
        public GraphService(ILogger<JobFolderService> logger)
        {
            _logger = logger;
        }

        public async Task<string> GetAccessTokenConfidentialClientAsync(string clientId, string tenantId,
            string clientSecret, string authority)
        {
            // Define the scopes you need
            var scopes = new[]
            {
                "https://graph.microsoft.com/.default"
            };

            try
            {
                var publicClient = ConfidentialClientApplicationBuilder.Create(clientId)
                    .WithClientSecret(clientSecret)
                    .WithAuthority(authority)
                    .WithTenantId(tenantId)
                    .WithRedirectUri("http://localhost:7181/auth/login-callback-ms")
                    .Build();

                var token = await publicClient.AcquireTokenForClient(scopes)
                    .WithTenantIdFromAuthority(new Uri(authority))
                    .ExecuteAsync();

                var accessToken = token.AccessToken;

                return accessToken;
            }
            catch (MsalUiRequiredException ex)
            {
                _logger.LogCritical($"Error acquiring token: {ex.Message}");
                throw;
            }
        }

        public async Task<string> GetAccessTokenWithClientCredentialAsync(string clientId, string tenantId,
            string clientSecret,
            CancellationToken cancellationToken = default)
        {
            // Define the scopes you need
            var scopes = new[]
            {
                "https://graph.microsoft.com/.default"
            };

            try
            {
                var options = new ClientSecretCredentialOptions
                {
                    AuthorityHost = AzureAuthorityHosts.AzurePublicCloud
                };

                var credential = new ClientSecretCredential(tenantId, clientId, clientSecret, options);

                var tokenRequestContext = new TokenRequestContext(scopes);
                var token = await credential.GetTokenAsync(tokenRequestContext, cancellationToken);
                var accessToken = token.Token;

                return accessToken;
            }
            catch (MsalUiRequiredException ex)
            {
                _logger.LogCritical($"Error acquiring token: {ex.Message}");
                throw;
            }
        }

        public Task<GraphServiceClient> GetGraphServiceClient(string clientId, string tenantId, string clientSecret)
        {
            var credential = new ClientSecretCredential(tenantId, clientId, clientSecret);
            var graphClient = new GraphServiceClient(credential);
            return Task.FromResult(graphClient);
        }
        //https://dev.to/showmen_dasgupta_08171571/using-microsoft-graph-api-with-net-a-comprehensive-guide-4jk1
        //public async Task<UserExtended?> GetUserIfExists(GraphServiceClient graphClient, string userId, string authToken)
        //{
        //    //var currentUser = await graphClient.Users[userId]
        //    //    .GetAsync();
        //    //return currentUser as UserExtended;
        //}
    }
}
