using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMApplication.Dtos.PlanModels
{
    public partial class CreateLayoutDto
    {
        public int BrandId { get; set; }
        public int CountryId { get; set; }
        public int RegionId { get; set; }
        public int StandTypeId { get; set; }
        public int StandId { get; set; }
        public string? Name { get; set; }
        public string CountryIds { get; set; }
        public string RegionIds { get; set; }
    }
}
