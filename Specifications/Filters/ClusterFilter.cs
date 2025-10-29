using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMApplication.Specifications.Filters
{
    public class ClusterFilter : BaseFilter
    {
        public long Id { get; set; }
        public int? BrandId { get; set; }
        public string? UserId { get; set; }
        public int? CountryId { get; set; }
        public int? RegionId { get; set; }
        public int? StandId { get; set; }
        public int? StandTypeId { get; set; }
        public bool? Published { get; set; }
        public int? StatusId { get; set; }
        public string? Name { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public DateTime? DateSubmitted { get; set; }
        public string? standName { get; set; }
        public string? standType { get; set; }
        public int? standHeight { get; set; }
        public int? standWidth { get; set; }
    }
}
