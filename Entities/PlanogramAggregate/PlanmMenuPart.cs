using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMApplication.Entities.PlanogramAggregate
{
    public partial class PlanmMenuPart
    {
        public long Id { get; set; }
        public string? PartNumber { get; set; }
        public string? AltPartNumber { get; set; }
        public string? CustomerRefNo { get; set; }
        public int PartTypeId { get; set; }
        public string? PartType { get; set; }
        public int ParentCategoryId { get; set; }
        public string? CategoryName { get; set; }
        public string? Name { get; set; }
        public short Facings { get; set; }
        public short? Stock { get; set; }
        public bool Discontinued { get; set; }
        public bool Published { get; set; }
        public string? SvgLineGraphic { get; set; }
        public string? Render2dImage { get; set; }
        public short Height { get; set; }
        public short Width { get; set; }
        public short? ShoppingHeight { get; set; }

        public string? ManufacturingProcess { get; set; }
        public string? Presentation { get; set; }
        public string? TestingType { get; set; }
        public string Description { get; set; }
        public string? PackShotImageSrc { get; set; }
        public decimal UnitCost { get; set; }
        public decimal? LaunchPrice { get; set; }
        public DateTime? LaunchDate { get; set; }
        public bool DmiReco { get; set; }
        public int CategoryId { get; set; }
        public string? CassetteBio { get; set; }
        public int? PartStatusId { get; set; }
    }
}
