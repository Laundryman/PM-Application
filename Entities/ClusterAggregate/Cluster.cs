using PMApplication.Entities.PlanogramAggregate;
using PMApplication.Entities.StandAggregate;
using PMApplication.Interfaces;

namespace PMApplication.Entities.ClusterAggregate;

public partial class Cluster : BaseEntity<long>, IAggregateRoot
{
    public int StandId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string? ImageSrc { get; set; }

    public int? Rows { get; set; }

    public int? Cols { get; set; }

    public int? ShelfIncrement { get; set; }

    public string? Header { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime DateUpdated { get; set; }

    public DateTime DateAvailable { get; set; }

    public bool Published { get; set; }

    public int LegacyUserId { get; set; }

    public int? HeaderHeight { get; set; }

    public int StatusId { get; set; }

    public int CurrentVersion { get; set; }

    public int BrandId { get; set; }

    public string? ClusterPartNumber { get; set; }

    public long? ScratchPadId { get; set; }

    public string? UserId { get; set; }

    public string? UserName { get; set; }

    public string? Lubname { get; set; }

    public virtual Brand Brand { get; set; } = null!;

    public virtual ICollection<ClusterColumn> ClusterColumns { get; set; } = new List<ClusterColumn>();

    public virtual ICollection<ClusterPart> ClusterParts { get; set; } = new List<ClusterPart>();

    public virtual ICollection<ClusterShelf> ClusterShelves { get; set; } = new List<ClusterShelf>();

    public virtual ICollection<Planogram> Planograms { get; set; } = new List<Planogram>();

    public virtual Stand Stand { get; set; } = null!;
}
