using PMApplication.Interfaces;

namespace PMApplication.Entities.OrderAggregate;

public partial class Order : BaseEntity<long>, IAggregateRoot
{
    public int OrderStatus { get; set; }

    public DateTime OrderCreated { get; set; }

    public DateTime OrderUpdated { get; set; }

    public int LegacyOrderCreatedBy { get; set; }

    public int LegacyOrderUpdatedBy { get; set; }

    public string OrderUpdatedByName { get; set; } = null!;

    public string OrderCreatedByName { get; set; } = null!;

    public int CountryId { get; set; }

    public int RegionId { get; set; }

    public string? OrderTitle { get; set; }

    public int? BrandId { get; set; }

    public DateTime? OrderSubmitted { get; set; }

    public string? OrderCreatedBy { get; set; }

    public string? OrderUpdatedBy { get; set; }
}
