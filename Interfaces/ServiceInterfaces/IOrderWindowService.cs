using PMApplication.Entities.OrderAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMApplication.Specifications.Filters;

namespace PMApplication.Interfaces.ServiceInterfaces
{
    public interface IOrderWindowService
    {
        Task<IReadOnlyList<OrderWindow>> GetOrderWindows(OrderWindowFilter filter);

        //Task<IReadOnlyCollection<OrderWindow>> GetOrderWindowCalendar(int brandId);
        //Task<IReadOnlyCollection<OrderWindowInfo>> GetFilteredOrderWindows(int brandId, int? page,
        //    int? pageSize,
        //    string sortBy,
        //    string sortOrder,
        //    string searchString);


        Task<OrderWindow> GetOrderWindow(int id);
        void CreateOrderWindow(OrderWindow orderWindow);
        void DeleteOrderWindow(int id);
        void SaveOrderWindow();
    }
}
