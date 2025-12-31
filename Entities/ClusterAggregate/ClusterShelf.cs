using PMApplication.Entities.PartAggregate;
using PMApplication.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMApplication.Entities.ClusterAggregate;

public partial class ClusterShelf : BaseEntity<long>, IAggregateRoot
{
    public long ClusterId { get; set; }

    public short Height { get; set; }

    public short Width { get; set; }

    public short? Column { get; set; }

    public short? Row { get; set; }

    public int PositionX { get; set; }

    public int PositionY { get; set; }

    [ForeignKey("Part")]
    public long PartId { get; set; }

    public int PartStatusId { get; set; }

    public int ShelfTypeId { get; set; }

    public virtual Cluster Cluster { get; set; } = null!;
    public virtual Part Part { get; set; } = null!;

    public virtual ICollection<ClusterPart> ClusterParts { get; set; } = new List<ClusterPart>();
}
