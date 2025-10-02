using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMApplication.Dtos.PlanModels
{
    public class ExportSkuDto
    {
        public int ColumnId { get; set; }
        public int ColumnPosition { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public string PartNumber { get; set; }
        public string AltPartNumber { get; set; }
        public string CustomerRefNo { get; set; }
        public string PartName { get; set; }
        public string PartStatus { get; set; }
        public string ProductName { get; set; }
        public string ShadeName { get; set; }
        public string FacingStatus { get; set; }
        public string ShadeEAN { get; set; } //Used for EAN Number
        public int? Facings { get; set; }
        public int? Stock { get; set; }
        public int? TotalSKU { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public decimal? UnitCost { get; set; }
    }
}
