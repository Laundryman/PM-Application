using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMApplication.Dtos.PlanModels
{
    public class PlanmMenuDto
    {
        public int BrandId { get; set; }
        public int CountryId { get; set; }
        public int StandTypeId { get; set; }

        public string? BrandName { get; set; }
        public string? CountryName { get; set; }
        public string? StandTypeName { get; set; }

        public List<CategoryMenuDto>? Categories { get; set; }
    }
}
