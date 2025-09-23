using PMApplication.Interfaces;

namespace PMApplication.Entities.ClusterAggregate;

public partial class ClusterColumn : BaseEntity<int>, IAggregateRoot
{
    public long ClusterId { get; set; }

    public int Width { get; set; }

    public virtual Cluster Cluster { get; set; } = null!;
}
