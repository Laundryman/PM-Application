using PMApplication.Dtos.PlanModels;
using PMApplication.Entities.OrderAggregate;
using PMApplication.Entities.PartAggregate;

namespace PMApplication.Interfaces.RepositoryInterfaces
{
    public interface IOrderRepository : IAsyncRepositoryLong<Order>
    {
    }
}
