using PMApplication.Entities.PartAggregate;

namespace PMApplication.Entities.StandAggregate;

public partial class StandTypePart
{
    public int StandTypeId { get; set; }

    public long PartId { get; set; }

    public virtual Part Part { get; set; } = null!;
    public virtual StandType StandType { get; set; } = null!;
}
