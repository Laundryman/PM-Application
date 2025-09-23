using PMApplication.Interfaces;

namespace PMApplication.Entities.PlanogramAggregate;

public partial class PlanogramItemStatus : BaseEntity<int>, IAggregateRoot
{
    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Hex { get; set; } = null!;

    public int? R { get; set; }

    public int? G { get; set; }

    public int? B { get; set; }

    public int? A { get; set; }

    public int? DisplaySortOrder { get; set; }

    public virtual ICollection<PlanogramPartFacing> PlanogramPartFacings { get; set; } = new List<PlanogramPartFacing>();

    public virtual ICollection<PlanogramPart> PlanogramParts { get; set; } = new List<PlanogramPart>();

    public virtual ICollection<PlanogramShelf> PlanogramShelves { get; set; } = new List<PlanogramShelf>();
}
