using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMApplication.Entities.PlanogramAggregate
{
    public partial class Sku
    {
        [Key]
        public int SkuItemId { get; set; }
        public int ColumnId { get; set; }
        public int ColumnPosition { get; set; }
        public int? PlanogramPartsId { get; set; }
        public int? PlanogramShelfId { get; set; }
        public string CustomerEmail { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public string PartNumber { get; set; }
        public string AltPartNumber { get; set; }
        public string CustomerRefNo { get; set; }
        public string PartName { get; set; }
        public string PartStatus { get; set; }
        public string ProductName { get; set; }
        public string ShadeName { get; set; }
        public string ShadeDescription { get; set; } //Used for EAN Number
        public string FacingStatus { get; set; }
        public int? Facings { get; set; }
        public int? Stock { get; set; }
        public int? TotalSKU { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public int? PartType { get; set; }
        public string PartTypeName { get; set; }
        public int? FacingPosition { get; set; }
        public int? PositionX { get; set; }
        public int? PositionY { get; set; }
        public int? ShelfPosX { get; set; }
        public int? ShelfPosY { get; set; }
        public decimal? UnitCost { get; set; }
    }
}
