using PMApplication.Entities.JobsAggregate;
using PMApplication.Interfaces;

namespace PMApplication.Entities.CountriesAggregate;

public partial class Region : BaseEntity<int>, IAggregateRoot
{
    public string Name { get; set; } = null!;

    public int ZoneId { get; set; }

    public int? BrandId { get; set; }

    public string? CountryList { get; set; }

    //public virtual List<CountryRegion> CountryRegion { get; } = [];    
    public virtual List<Country> Countries { get; } = [];

    public virtual List<JobFolder> JobFolders { get;} = [];



    //public virtual ICollection<UserProfile> UserProfiles { get; set; } = new List<UserProfile>();
}
