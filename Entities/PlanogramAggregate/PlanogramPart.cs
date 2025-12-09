using PMApplication.Entities.CountriesAggregate;
using PMApplication.Entities.PartAggregate;
using PMApplication.Entities.ProductAggregate;
using PMApplication.Interfaces;

namespace PMApplication.Entities.PlanogramAggregate;

public partial class PlanogramPart : BaseEntity<long>, IAggregateRoot
{
    public int PositionX { get; set; }

    public int PositionY { get; set; }

    public long? PlanogramShelfId { get; set; }

    public long? ScratchPadId { get; set; }

    public long PartId { get; set; }

    public long PlanogramId { get; set; }

    public long? PlanogramPartPlanogramPartsId { get; set; }

    public string? Notes { get; set; }

    public int? PartStatusId { get; set; }

    public DateTime? DateUpdated { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? Label { get; set; }

    //public virtual ICollection<PlanogramPart> InversePlanogramPartPlanogramParts { get; set; } = new List<PlanogramPart>();

    public virtual Part Part { get; set; } = null!;

    public virtual PlanogramItemStatus? PartStatus { get; set; }

    public virtual Planogram Planogram { get; set; } = null!;

    public virtual ICollection<PlanogramPartFacing> PlanogramPartFacings { get; set; } = new List<PlanogramPartFacing>();

    public virtual PlanogramPart? PlanogramPartPlanogramParts { get; set; }

    public virtual PlanogramShelf? PlanogramShelf { get; set; }

    public virtual ScratchPad? ScratchPad { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    public virtual ICollection<Country> Countries { get; set; } = new List<Country>();
}
