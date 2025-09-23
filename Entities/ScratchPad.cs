using PMApplication.Entities.PlanogramAggregate;
using PMApplication.Interfaces;

namespace PMApplication.Entities;

public partial class ScratchPad : BaseEntity<long>, IAggregateRoot
{
    public DateTime DateCreated { get; set; }

    public DateTime DateUpdated { get; set; }

    public virtual ICollection<PlanogramPart> PlanogramParts { get; set; } = new List<PlanogramPart>();

    public virtual ICollection<PlanogramShelf> PlanogramShelves { get; set; } = new List<PlanogramShelf>();
}
