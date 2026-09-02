using System;
using System.Collections.Generic;
using System.Text;

namespace PMApplication.Dtos.Filters
{
    public class ReportingFilterDto
    {
        public int BrandId { get; set; }
        public int? RegionId { get; set; }
        public int? CountryId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int RoleId { get; set; }
        public int ActionType { get; set; } = 1;
        public int ActionId { get; set; }

    }
}
