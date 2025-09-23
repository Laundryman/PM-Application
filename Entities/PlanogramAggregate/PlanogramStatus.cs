using PMApplication.Interfaces;

namespace PMApplication.Entities.PlanogramAggregate;

public partial class PlanogramStatus : BaseEntity<int>, IAggregateRoot
{
    public string Name { get; set; } = null!;

    public virtual ICollection<Planogram> Planograms { get; set; } = new List<Planogram>();
}
