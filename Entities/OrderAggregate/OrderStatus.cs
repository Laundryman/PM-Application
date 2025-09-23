using PMApplication.Interfaces;

namespace PMApplication.Entities.OrderAggregate;

public partial class OrderStatus : BaseEntity<int>, IAggregateRoot
{

    public string Name { get; set; } = null!;
}
