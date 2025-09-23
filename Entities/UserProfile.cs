using PMApplication.Entities.CountriesAggregate;

namespace PMApplication.Entities;

public partial class UserProfile
{
    public int UserId { get; set; }

    public string? UserName { get; set; }

    public string? Email { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public int? CountryId { get; set; }

    public int? RegionId { get; set; }

    public virtual Country? Country { get; set; }

    public virtual Region? Region { get; set; }

    public virtual ICollection<WebpagesUsersInRole> WebpagesUsersInRoles { get; set; } = new List<WebpagesUsersInRole>();
}
