using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMApplication.Dtos.Filters
{
    public class PlanogramFilterDto
    {
        public long Id { get; set; }
        public int? BrandId { get; set; }
        public int? StatusId { get; set; }  
        public int? StandTypeId { get; set; }
        public bool? Locked { get; set; }
        public int? RegionId { get; set; }
        public int? CountryId { get; set; }
        public string? CountriesList { get; set; }
    }
}
