namespace PMApplication.Dtos
{
    public interface ICurrentUser
    {
        public string? Password { get; }
        public string? Id { get; }
        public int DiamCountryId { get; }
        //public CountryViewModel Country { get; }
        public string? DiamCountryName { get; }
        public int DiamUserId { get; }
        public string? BrandIds { get; }
        public string? Brands { get; }
        public string? BrandNameList { get; }
        public string? RoleIds { get; }
        public string? Roles { get; }
        public string? RoleNameList { get; }
        public string? GivenName { get; }
        public string? Surname { get; }
        public string? Email { get; }
        public string? UserName { get; }
        public string? DisplayName { get; }
        public string? MailNickName { get; }
    }

    public class CurrentUser : ICurrentUser
    {
        public string? Password { get; set; }
        public string? Id { get; set; }
        public int DiamCountryId { get; set; }
        public string? DiamCountryName { get; set; }
        public int DiamUserId { get; set; }
        public string? BrandIds { get; set; }
        public string? Brands { get; set; }
        public string? BrandNameList { get; set; }
        public string? RoleIds { get; set; }
        public string? Roles { get; set; }
        public string? RoleNameList { get; set; }
        public string? GivenName { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }
        public string? UserName { get; set; }
        public string? DisplayName { get; set; }
        public string? MailNickName { get; set; }
    }
}
