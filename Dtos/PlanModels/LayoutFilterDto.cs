using System;
using System.Collections.Generic;
using System.Text;

namespace PMApplication.Dtos.PlanModels
{
    public class LayoutFilterDto
    {
        public int BrandId { get; set; }
        public int CountryId { get; set; }
        public int StandTypeId { get; set; }
        public int StandId { get; set; }
    }
}
