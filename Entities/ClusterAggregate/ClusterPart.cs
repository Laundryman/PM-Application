using PMApplication.Entities.PartAggregate;
using PMApplication.Interfaces;

namespace PMApplication.Entities.ClusterAggregate;

public partial class ClusterPart : BaseEntity<long>, IAggregateRoot
{
    public long ClusterId { get; set; }

    public long PartId { get; set; }

    public int PositionX { get; set; }

    public int PositionY { get; set; }

    public string? Notes { get; set; }

    public long? ClusterShelfId { get; set; }

    public int PartStatusId { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? DateUpdated { get; set; }

    public int? ScratchPadId { get; set; }

    public virtual Cluster Cluster { get; set; } = null!;

    public virtual ClusterShelf? ClusterShelf { get; set; }

    public virtual Part Part { get; set; } = null!;
}
