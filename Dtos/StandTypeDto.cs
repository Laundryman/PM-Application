using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PMApplication.Dtos
{
    public class StandTypeDto
    {
        public IEnumerable<SelectListItem> ParentStandTypes { get; set; }
        public int StandTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ParentStandTypeId { get; set; }
        public string ParentStandTypeName { get; set; }
        public int? BrandId { get; set; }
        public string BrandName { get; set; }
        public string BrandLogo { get; set; }
        public bool Lock { get; set; }
        public int StandCount { get; set; }
        public string StandImage { get; set; }
        public bool HidePrices { get; set; }
    }
}
