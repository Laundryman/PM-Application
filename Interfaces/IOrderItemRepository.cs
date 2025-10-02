using PMApplication.Dtos.PlanModels;
using PMApplication.Entities.OrderAggregate;
using PMApplication.Entities.PartAggregate;

namespace PMApplication.Interfaces
{
    public interface IOrderItemRepository : IAsyncRepositoryLong<OrderItem>
    {
        Task<IReadOnlyList<OrderItemInfo>?> GetOrderItems(long orderId);
    }
}
