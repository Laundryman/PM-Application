using PMApplication.Entities.JobsAggregate;
using PMApplication.Interfaces;

namespace PMApplication.Entities.StandAggregate;

public partial class StandType : BaseEntity<int>, IAggregateRoot
{
    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int? ParentStandTypeId { get; set; }

    public int? BrandId { get; set; }

    public bool Lock { get; set; }

    public string? StandImage { get; set; }

    public int? FullSectionColumnWidth { get; set; }

    public int? HalfSectionColumnWidth { get; set; }

    public bool HidePrices { get; set; }

    public virtual StandType ParentStandType { get; set; } = null!;
    public virtual ICollection<JobFolder> JobFolders { get; set; } = new List<JobFolder>();
}
