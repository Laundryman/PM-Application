using PMApplication.Entities.CountriesAggregate;
using PMApplication.Entities.PartAggregate;
using PMApplication.Entities.PlanogramAggregate;
using PMApplication.Interfaces;

namespace PMApplication.Entities;

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

    public string? CountryList { get; set; }

    public virtual Brand Brand { get; set; } = null!;

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<HeroProduct> HeroProducts { get; set; } = [];

    public virtual ICollection<PlanogramPartFacing> PlanogramPartFacings { get; set; } = [];

    public virtual ICollection<Shade> Shades { get; set; } = [];

    public virtual ICollection<Country> Countries { get; set; } = [];

    public virtual List<PartProduct> Parts { get; set; } = [];

    public virtual ICollection<PlanogramPart> PlanogramParts { get; set; } = [];
}
