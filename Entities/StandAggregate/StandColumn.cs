using PMApplication.Interfaces;

namespace PMApplication.Entities.StandAggregate;

public partial class StandColumn : BaseEntity<int>, IAggregateRoot
{
    public int StandId { get; set; }

    public int Position { get; set; }

    public int Width { get; set; }

    public virtual ICollection<StandColumnUpright> StandColumnUprights { get; set; } = new List<StandColumnUpright>();
}
