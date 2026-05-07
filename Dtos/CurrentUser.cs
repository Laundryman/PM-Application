using PMApplication.Entities.CountriesAggregate;

namespace PMApplication.Dtos
{
    public interface ICurrentUser
    {
        public string? Password { get; }
        public string? Id { get; }
        public int CountryId { get; }
        //public CountryViewModel Country { get; }
        public string? CountryName { get; }
        //public int DiamUserId { get; }
        public string? BrandIds { get; }
        public string? Brands { get; }
        public string? BrandNameList { get; }
        public string? RoleIds { get; }
        public string? Roles { get; }
        public string? Role { get; }
        public string? Permissions { get; }
        public string? RoleNameList { get; }
        public string? GivenName { get; }
        public string? Surname { get; }
        public string? Email { get; }
        public string? UserName { get; }
        public string? DisplayName { get; }
        public string? MailNickName { get; }
        public string? CountryList { get; set; }
        public string? RegionList { get; set; }
        public List<Region>? Regions { get; set; }
        public List<Country>? Countries { get; set; }

    }

    public class CurrentUser : ICurrentUser
    {
        public string? Password { get; set; }
        public string? Id { get; set; }
        public int CountryId { get; set; }
        public string? CountryName { get; set; }
        //public int DiamUserId { get; set; }
        public string? BrandIds { get; set; }
        public string? Brands { get; set; }
        public string? BrandNameList { get; set; }
        public string? RoleIds { get; set; } //deprecated
        public string? RoleId { get; set; }
        public string? Roles { get; set; } // deprecated
        public string? Role { get; set; }
        public string? Permissions { get; set; }
        public string? RoleNameList { get; set; }
        public string? GivenName { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }
        public string? UserName { get; set; }
        public string? DisplayName { get; set; }
        public string? MailNickName { get; set; }
        public string? CountryList { get; set; }
        public string? RegionList { get; set; }
        public List<Region>? Regions { get; set; }
        public List<Country>? Countries { get; set; }
    }
}
