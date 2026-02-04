using PMApplication.Entities.ClusterAggregate;
using PMApplication.Entities.CountriesAggregate;
using PMApplication.Entities.PlanogramAggregate;
using PMApplication.Entities.ProductAggregate;
using PMApplication.Entities.StandAggregate;
using PMApplication.Interfaces;

namespace PMApplication.Entities.PartAggregate;

public partial class Part : BaseEntity<long>, IAggregateRoot
{
    public string? AltPartNumber { get; set; }
    public int BrandId { get; set; }
    public string? CassetteBio { get; set; }
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
    public string? CountriesList { get; set; }
    public string? RegionsList { get; set; }
    public string? CustomerRefNo { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime? DateUpdated { get; set; }
    public short Depth { get; set; }
    public string Description { get; set; } = null!;
    public bool Discontinued { get; set; }
    public bool DmiReco { get; set; }
    public short Facings { get; set; }
    public short Height { get; set; }
    public bool InternationalPart { get; set; }
    public DateTime? LaunchDate { get; set; }
    public decimal? LaunchPrice { get; set; }
    public string? ManufacturingProcess { get; set; }
    public string Name { get; set; } = null!;
    public string? PackShotImageSrc { get; set; }
    public int? ParentCategoryId { get; set; }
    public string? ParentCategoryName { get; set; }
    public string? PartNumber { get; set; }
    public int PartTypeId { get; set; }
    public string? PartTypeName { get; set; }
    public string? PlanoImageSrc { get; set; }
    public string? Presentation { get; set; }
    public string? ProductList { get; set; }
    public bool Published { get; set; }
    public int? RegionId { get; set; }
    //public string? RegionName { get; set; }
    public string? Render2dImage { get; set; }
    public bool? ShadeSelectByFacing { get; set; }
    public bool Shoppable { get; set; }
    public short? ShoppingHeight { get; set; }
    public string? StandTypeList { get; set; }
    public short Stock { get; set; }
    public string? SvgLineGraphic { get; set; }
    public string? TestingType { get; set; }
    public decimal UnitCost { get; set; }
    public short Width { get; set; }

    public virtual Brand Brand { get; set; } = null!;

    public virtual Category Category { get; set; } = null!;

    public virtual List<ClusterPart> ClusterParts { get; protected set; } = [];

    public virtual PartType PartType { get; set; } = null!;

    public virtual List<PlanogramPart> PlanogramParts { get; protected set; } = [];

    public virtual List<PlanogramShelf> PlanogramShelves { get; protected set; } = [];

    public virtual List<Region> Regions { get; protected set; } = [];
    public virtual List<Country> Countries { get; protected set; } = [];

    public virtual List<Product> Products { get; protected set; } = [];

    public virtual List<Stand> Stands { get; protected set; } = [];
    public virtual List<StandType> StandTypes { get; protected set; } = [];

}
