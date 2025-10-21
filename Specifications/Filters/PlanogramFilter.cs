using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMApplication.Specifications.Filters
{
    public class PlanogramFilter
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int CountryId { get; set; }
        public int RegionId { get; set; }
        public int StandTypeId { get; set; }
        public string UserId { get; set; }
        public string JobCode { get; set; }
        public int StatusId { get; set; }

    }
}
