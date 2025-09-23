using PMApplication.Interfaces;

namespace PMApplication.Entities.PlanogramAggregate;

public partial class PlanogramPartFacing : BaseEntity<long>, IAggregateRoot
{
    public long PlanogramPartsId { get; set; }

    public long PlanogramId { get; set; }

    public long ProductId { get; set; }

    public int StockCount { get; set; }

    public long? ShadeId { get; set; }

    public int? Position { get; set; }

    public int? FacingStatusId { get; set; }

    public virtual PlanogramItemStatus? FacingStatus { get; set; }

    public virtual Planogram Planogram { get; set; } = null!;

    public virtual PlanogramPart PlanogramPart { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;

    public virtual Shade? Shade { get; set; }
}
