using PMApplication.Entities.JobsAggregate;
using PMApplication.Entities.PartAggregate;
using PMApplication.Entities.PlanogramAggregate;
using PMApplication.Entities.StandAggregate;
using PMApplication.Interfaces;

namespace PMApplication.Entities.CountriesAggregate;

public partial class Country : BaseEntity<int>, IAggregateRoot
{
    public string Name { get; set; } = null!;

    public int? RegionId { get; set; }

    public string ThreeLetterIsoCode { get; set; } = null!;

    public string TwoLetterIsoCode { get; set; } = null!;

    public bool? Active { get; set; }

    public string? FlagFileName { get; set; }

    //public virtual Region? Region { get; set; }

    public virtual List<CountryRegion> RegionCountries { get; } = [];

    //public virtual ICollection<UserProfile> UserProfiles { get; set; } = new List<UserProfile>();

    public virtual List<Stand> Stands { get; set; } = new List<Stand>();
    public virtual List<JobFolder> JobFolders { get; set; } = new List<JobFolder>();

    public virtual List<Part> Parts { get; set; } = new List<Part>();

    public virtual List<Product> Products { get; set; } = new List<Product>();

    public virtual List<PlanogramPart> PlanogramParts { get; set; } = new List<PlanogramPart>();


    public virtual List<Shade> Shades { get; set; } = new List<Shade>();
    public virtual List<Region> Regions { get;} = [];
    //public virtual ICollection<CountryPart> CountryParts { get; } = new List<CountryPart>();
}
