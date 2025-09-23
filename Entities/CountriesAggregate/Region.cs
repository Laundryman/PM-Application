using PMApplication.Entities.JobsAggregate;
using PMApplication.Interfaces;

namespace PMApplication.Entities.CountriesAggregate;

public partial class Region : BaseEntity<int>, IAggregateRoot
{
    public string Name { get; set; } = null!;

    public int ZoneId { get; set; }

    public int? BrandId { get; set; }

    public string? CountryList { get; set; }

    public virtual ICollection<Country> Countries { get; set; } = new List<Country>();

    public virtual ICollection<JobFolder> JobFolders { get; set; } = new List<JobFolder>();

    public virtual ICollection<RegionCountry> RegionCountries { get; set; } = new List<RegionCountry>();

    //public virtual ICollection<UserProfile> UserProfiles { get; set; } = new List<UserProfile>();
}
