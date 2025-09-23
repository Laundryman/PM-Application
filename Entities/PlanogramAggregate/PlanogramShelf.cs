using PMApplication.Entities.PartAggregate;
using PMApplication.Interfaces;

namespace PMApplication.Entities.PlanogramAggregate;

public partial class PlanogramShelf : BaseEntity<long>, IAggregateRoot
{
    public short? Height { get; set; }

    public short Width { get; set; }

    public short? Column { get; set; }

    public short? Row { get; set; }

    public int PositionX { get; set; }

    public int PositionY { get; set; }

    public long PlanogramId { get; set; }

    public long PartId { get; set; }

    public int? PartStatusId { get; set; }

    public string? Label { get; set; }

    public int ShelfTypeId { get; set; }

    public long? ScratchPadId { get; set; }

    public virtual Part Part { get; set; } = null!;

    public virtual PlanogramItemStatus? PartStatus { get; set; }

    public virtual ICollection<PlanogramPart> PlanogramParts { get; set; } = new List<PlanogramPart>();

    public virtual Planogram Planogram { get; set; } = null!;

    public virtual ScratchPad? ScratchPad { get; set; }
}
