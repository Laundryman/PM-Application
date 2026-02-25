using PMApplication.Entities.CountriesAggregate;
using PMApplication.Entities.PartAggregate;
using PMApplication.Entities.PlanogramAggregate;
using PMApplication.Interfaces;

namespace PMApplication.Entities.ProductAggregate;

public partial class Product : BaseEntity<long>, IAggregateRoot
{
    public string Name { get; set; } = null!;

    public string? ShortDescription { get; set; }

    public string FullDescription { get; set; } = null!;

    public int BrandId { get; set; }

    public int CategoryId { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime? DateUpdated { get; set; }

    public DateTime? DateAvailable { get; set; }

    public bool Published { get; set; }

    public string? ProductImage { get; set; }

    public bool? Discontinued { get; set; }

    public bool Hero { get; set; }

    public int? ParentCategoryId { get; set; }

    public string? CountriesList { get; set; }
    public string? RegionsList { get; set; }

    public virtual Brand Brand { get; set; } = null!;

    public virtual Category Category { get; set; } = null!;

    public virtual List<HeroProduct> HeroProducts { get; set; } = [];

    public virtual List<PlanogramPartFacing> PlanogramPartFacings { get; set; } = [];

    public virtual List<Shade> Shades { get; set; } = [];

    public virtual List<Region> Regions { get; protected set; } = [];
    public virtual List<Country> Countries { get; protected set; } = [];


    public virtual List<Part> Parts { get; set; } = [];

    public virtual List<PlanogramPart> PlanogramParts { get; set; } = [];
}
