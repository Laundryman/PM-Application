using PMApplication.Entities.ClusterAggregate;
using PMApplication.Entities.CountriesAggregate;
using PMApplication.Entities.PlanogramAggregate;
using PMApplication.Entities.StandAggregate;
using PMApplication.Interfaces;

namespace PMApplication.Entities.PartAggregate;

public partial class Part : BaseEntity<long>, IAggregateRoot
{
    public string Name { get; set; } = null!;
    public string? PartNumber { get; set; }
    public string? AltPartNumber { get; set; }
    public string? CustomerRefNo { get; set; }
    public int PartTypeId { get; set; }
    public int CategoryId { get; set; }

    public short Facings { get; set; }

    public string Description { get; set; } = null!;

    public short Height { get; set; }

    public short Width { get; set; }

    public short Stock { get; set; }


    public string? PlanoImageSrc { get; set; }

    public string? PackShotImageSrc { get; set; }

    public short? ShoppingHeight { get; set; }

    public int BrandId { get; set; }


    public DateTime DateCreated { get; set; }

    public DateTime? DateUpdated { get; set; }

    public bool Published { get; set; }

    public bool? ShadeSelectByFacing { get; set; }

    public bool Discontinued { get; set; }

    public decimal UnitCost { get; set; }

    public short Depth { get; set; }

    public string? Render2dImage { get; set; }



    public string? SvgLineGraphic { get; set; }

    public string? ManufacturingProcess { get; set; }

    public string? TestingType { get; set; }

    public bool InternationalPart { get; set; }

    public bool Shoppable { get; set; }

    public decimal? LaunchPrice { get; set; }

    public DateTime? LaunchDate { get; set; }

    public string? CassetteBio { get; set; }

    public string? Presentation { get; set; }

    public bool DmiReco { get; set; }

    public int? ParentCategoryId { get; set; }

    public string? ParentCategoryName { get; set; }

    public string? CountryList { get; set; }

    public int? RegionId { get; set; }

    public virtual Brand Brand { get; set; } = null!;

    public virtual Category Category { get; set; } = null!;

    public virtual List<ClusterPart> ClusterParts { get; set; } = [];

    public virtual PartType PartType { get; set; } = null!;

    public virtual List<PlanogramPart> PlanogramParts { get; set; } = [];

    public virtual List<PlanogramShelf> PlanogramShelves { get; set; } = [];

    public virtual List<Country> Countries { get; set; } = [];

    public virtual List<PartProduct> Products { get; set; } = [];

    public virtual List<Stand> Stands { get; set; } = [];
    public virtual List<StandType> StandTypes { get; set; } = [];

}
