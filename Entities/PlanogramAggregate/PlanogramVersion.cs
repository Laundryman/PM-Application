using PMApplication.Interfaces;

namespace PMApplication.Entities.PlanogramAggregate;

public partial class PlanogramVersion : BaseEntity<int>, IAggregateRoot
{
    public string? Svg { get; set; }

    public int UserId { get; set; }

    public DateTime VersionDate { get; set; }

    public int VersionNo { get; set; }

    public int PlanogramId { get; set; }
}
