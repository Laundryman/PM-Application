using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMApplication.Entities;
using PMApplication.Interfaces;

namespace PMApplication.Dtos.PlanModels
{
    public class PlanmPartFacing : BaseEntity<long>, IAggregateRoot
    {
        public int FacingNo { get; set; }
        public int PlanogramFacingId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int PartId { get; set; }
        public int FacingType { get; set; }
        public long? ShadeId { get; set; }
        public string ShadeName { get; set; }
        public int? FacingStatus { get; set; }
    }
}
