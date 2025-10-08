using PMApplication.Entities.JobsAggregate;
using PMApplication.Interfaces;

namespace PMApplication.Entities.CountriesAggregate;

public partial class Region : BaseEntity<int>, IAggregateRoot
{
    public string Name { get; set; } = null!;

    public int ZoneId { get; set; }

    public int? BrandId { get; set; }

    public string? CountryList { get; set; }

    public List<CountryRegion> RegionCountries { get; } = [];    
    public List<Country> Countries { get; } = [];

    public virtual List<JobFolder> JobFolders { get;} = [];



    //public virtual ICollection<UserProfile> UserProfiles { get; set; } = new List<UserProfile>();
}
