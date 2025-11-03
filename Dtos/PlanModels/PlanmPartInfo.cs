using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMApplication.Dtos.PlanModels
{
    public class PlanmPartInfo
    {
        public string? Category { get; set; }
        public IEnumerable<PlanmPartFacing>? facingProducts { get; set; }
        public IEnumerable<ProductDto>? products { get; set; }

        public List<int>? CountryIds { get; set; }
        public string? CountryList { get; set; }

        public int? Facings { get; set; }
        public int Height { get; set; }
        public string? Name { get; set; }
        public string? Notes { get; set; }
        public string? Label { get; set; }
        public int? Stock { get; set; }
        public int? Width { get; set; }

        public int? PlanogramId { get; set; }
        public int? ClusterId { get; set; }
        public int? ScratchPadId { get; set; }
        public int? PlanogramPartId { get; set; }
        public int? ClusterPartId { get; set; }
        public int? ParentPlanogramPartId { get; set; }
        public long? PlanogramShelfId { get; set; }
        public int? ClusterShelfId { get; set; }
        public int? PlanogramColumnId { get; set; }
        //public string PlanxPartId { get; set; }
        //public string ParentPlanxPartId { get; set; }
        public string? PlanxShelfId { get; set; }

        public long? PartId { get; set; }
        public int? PartTypeId { get; set; }
        public int? ShelfTypeId { get; set; }
        public string? PartNumber { get; set; }
        public string? PartType { get; set; }
        public int? StatusId { get; set; }
        public string? Status { get; set; }
        public string? SvgLineGraphic { get; set; }
        public PlanmPosition Position { get; set; }
        public int? PlanogramPartPlanogramPartsId { get; set; }

        public string? ManufacturingProcess { get; set; }
        public string? Presentation { get; set; }
        public string? TestingType { get; set; }
        public string? Description { get; set; }
        public string? PackShotImageSrc { get; set; }
        public string? Render2dImage { get; set; }
        public decimal? UnitCost { get; set; }
        public decimal? LaunchPrice { get; set; }
        public DateTime? LaunchDate { get; set; }
        public string? CassetteBio { get; set; }
        public bool DmiReco { get; set; }
        public int? PartStatusId { get; set; }
        public int? ParentCategoryId { get; set; }
        public int? CategoryId { get; set; }
        public bool Discontinued { get; set; }
        public string? ShelfLabel { get; set; }

        public bool? PlanxPartAllowed { get; set; }

        public bool? NonMarket { get; set; }
    }
}
