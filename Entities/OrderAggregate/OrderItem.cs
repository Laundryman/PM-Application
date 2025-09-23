using PMApplication.Interfaces;

namespace PMApplication.Entities.OrderAggregate;

public partial class OrderItem : BaseEntity<long>, IAggregateRoot
{

    public long OrderId { get; set; }

    public int Quantity { get; set; }

    public DateTime DateAdded { get; set; }

    public int PartId { get; set; }

    public int? PlanogramId { get; set; }

    public string PartName { get; set; } = null!;

    public string PartNumber { get; set; } = null!;

    public decimal? Price { get; set; }

    public int InitialQuantity { get; set; }

    public int? OrderPlanogramId { get; set; }
}
