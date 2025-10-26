using PMApplication.Interfaces;

namespace PMApplication.Entities.PlanogramAggregate;

public class PlanogramPreview : BaseEntity<long>, IAggregateRoot
{
    public long PlanogramId { get; set; }

    public string? PreviewSrc { get; set; }

}
