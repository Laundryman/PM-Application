using PMApplication.Interfaces;

namespace PMApplication.Entities.PlanogramAggregate;

public partial class PlanogramSection : BaseEntity<int>, IAggregateRoot
{
    public Guid VirtualPlanoId { get; set; }

    public long PlanogramId { get; set; }

    public int UserId { get; set; }

    public DateTime DateCreated { get; set; }

    public int SectionStartPoint { get; set; }

    public int SectionEndPoint { get; set; }

    public string? PlanogramSectionName { get; set; }
}
