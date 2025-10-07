using PMApplication.Entities.ClusterAggregate;
using PMApplication.Entities.CountriesAggregate;
using PMApplication.Entities.StandAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using PMApplication.Specifications.Filters;
using Microsoft.AspNetCore.Mvc.Rendering;
using PMApplication.Entities.OrderAggregate;

namespace PMApplication.Interfaces.ServiceInterfaces
{
    public interface IOrderService
    {
        Task<Order> GetOrder(long id);
        Task<IReadOnlyList<Order>> GetOrders(OrderFilter filter);

        Task<IReadOnlyList<OrderInfo>> GetFilteredOrders(int brandId, int? page,
            int? pageSize,
            string sortBy,
            string sortOrder,
            string searchString,
            int? status,
            int? countryId, int? regionId);


        Task<IReadOnlyList<OrderExport>> GetOrderExport(int id);
        Task<IReadOnlyList<OrderItem>> GetOrderItems(OrderItemFilter filter);
        //Task<Order> GetOpenOrderByCountry(int countryId);
        //Task<IReadOnlyList<Order>> GetOpenOrdersByCountry(int countryId);
        Task<IReadOnlyList<SelectListItem>> GetOrderStatuses(int selected);
        void CreateOrder(Order order);
        Task DeleteOrder(int id);
        void SaveOrder();


        Task<OrderItem> GetOrderItem(int id);
        //Task<IReadOnlyList<OrderItem>> GetOrderItems();
        Task<IReadOnlyList<OrderItemInfo>> GetOrderItemInfos(long orderId);
        void CreateOrderItem(OrderItem OrderItem);
        void DeleteOrderItem(int id);
        void SaveOrderItem();

        Task DeletePlanogram(int orderId, int planogramId);
        Task DeleteFullPlanogram(int orderId, int orderPlanogramId);

        void AddPartsToOrder(int orderId, int planogramId, int quantity, string userId, string userName, bool isFullPlano);


    }
}
