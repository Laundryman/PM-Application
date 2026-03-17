using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMApplication.Dtos.StandTypes
{
    public class StandTypeUploadDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int? ParentStandTypeId { get; set; }
        public int? BrandId { get; set; }
        public bool Lock { get; set; }
        public string? StandImage { get; set; }
        public bool HidePrices { get; set; }
        public IFormFile? File { get; set; }


    }
}
