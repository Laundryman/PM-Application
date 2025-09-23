using PMApplication.Interfaces;

namespace PMApplication.Entities.PartAggregate;

public partial class PartType : BaseEntity<int>, IAggregateRoot
{
    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public virtual ICollection<Part> Parts { get; set; } = new List<Part>();
}
