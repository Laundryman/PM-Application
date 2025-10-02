using PMApplication.Entities.OrderAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMApplication.Dtos
{
    public class OrderDto
    {
        public int OrderId { get; set; }
        public string OrderTitle { get; set; }
        public int OrderStatus { get; set; }
        public DateTime OrderCreated { get; set; }
        public DateTime OrderUpdated { get; set; }
        public int TotalQuantity { get; set; }
        public decimal TotalPrice { get; set; }
        public bool HasLegacyItems { get; set; }
        public IEnumerable<OrderItemInfo> IndividualOrderItems { get; set; }
        public IEnumerable<OrderPlanogramDto> Planograms { get; set; }
    }
}
