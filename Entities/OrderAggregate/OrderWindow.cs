using PMApplication.Interfaces;

namespace PMApplication.Entities.OrderAggregate;

public partial class OrderWindow : BaseEntity<int>, IAggregateRoot
{
    public int BrandId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int LegacyCreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public int? LegacyUpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? CreatedByName { get; set; }

    public string? UpdatedBy { get; set; }

    public string? UpdatedByName { get; set; }

    public virtual Brand Brand { get; set; } = null!;
}
