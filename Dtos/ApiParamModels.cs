using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMApplication.Dtos
{
    public class GetMenuParams
    {
        public int? BrandId { get; set; }
        public int? StandTypeId { get; set; }
        public int? CountryId { get; set; }
        public long? PlanogramId { get; set; }
        public long? ClusterId { get; set; }
        public string? Category { get; set; }
        public long? PartId { get; set; }
    }

    public class GetPlanogramParams
    {
                public long? PlanogramId { get; set; }
                public int? StandId { get; set; }
    }
}
