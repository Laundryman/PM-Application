using PMApplication.Interfaces;

namespace PMApplication.Entities.StandAggregate;

public partial class StandColumnUpright : BaseEntity<int>, IAggregateRoot
{
    public int ColumnId { get; set; }

    public int StandId { get; set; }

    public int Width { get; set; }

    public int Height { get; set; }

    public int Position { get; set; }

    public virtual StandColumn Column { get; set; } = null!;
}
