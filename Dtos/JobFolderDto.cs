using Microsoft.AspNetCore.Mvc.Rendering;
using PMApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMApplication.Dtos
{
    public class JobFolderDto
    {
        public int Id { get; set; }
        public int ParentFolderId { get; set; }
        public int BrandId { get; set; }
        public int? RegionId { get; set; }

        public string BrandName { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public virtual BrandDto Brand { get; set; }
        public virtual RegionDto Region { get; set; }
        public List<JobDto> Jobs { get; set; }
        public List<CountryDto> Countries { get; set; }
        //public IEnumerable<string> SelectedCountries { get; set; }

        //public IEnumerable<SelectListItem> Regions { get; set; }
        //public IEnumerable<SelectListItem> Countries { get; set; }
    }
}
