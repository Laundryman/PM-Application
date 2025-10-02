using PMApplication.Entities.OrderAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMApplication.Dtos
{
    public class OrderPlanogramDto
    {
        public string Name { get; set; }
        public long PlanogramId { get; set; }
        public IEnumerable<OrderItemInfo> OrderItems { get; set; }
        public decimal PlanogramTotalValue { get; set; }
        public string ClusterName { get; set; }
        public string ClusterPartNumber { get; set; }
        public string StandName { get; set; }
        public string StandPartNumber { get; set; }
        public bool IsFullPlano { get; set; }
    }
}
