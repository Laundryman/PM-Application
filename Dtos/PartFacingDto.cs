using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMApplication.Dtos
{
    public partial class PartFacingDto
    {
        public int PlanogramPartFacingId { get; set; }
        public int Position { get; set; }
        public int PlanogramId { get; set; }
        public int ProductId { get; set; }
        public int CatPartId { get; set; }
        public int StockCount { get; set; }
        public int? FacingStatusId { get; set; } //this utilises the plano item status for moving planos
        public int? ShadeId { get; set; }
        public string? ShadeNumber { get; set; }
        public string? ShadeDescription { get; set; }
        public bool? Published { get; set; }
        public System.DateTime? DateCreated { get; set; }
        public System.DateTime? DateUpdated { get; set; }
        public System.DateTime? DateAvailable { get; set; }
    }
}
