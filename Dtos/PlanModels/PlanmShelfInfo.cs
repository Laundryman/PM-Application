using PMApplication.Entities;
using PMApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMApplication.Dtos.PlanModels
{
    public class PlanmShelfInfo : BaseEntity<long>, IAggregateRoot
    {
        public int PlanogramId { get; set; }
        public int PartId { get; set; }
        //public int PlanogramShelfId { get; set; }
        public int ClusterShelfId { get; set; }
        public string? PlanxShelfId { get; set; }
        public int? ScratchPadId { get; set; }
        public int ShelfTypeId { get; set; }
        public string? PartNumber { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public string? Label { get; set; }
        public int? StatusId { get; set; }
        public int Column { get; set; }
        public string? Notes { get; set; }
        public string? SvgLineGraphic { get; set; }
        public PlanmPosition Position { get; set; }
        public IEnumerable<PlanmPartInfo>? Parts { get; set; }
    }
}
