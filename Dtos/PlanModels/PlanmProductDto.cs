using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMApplication.Dtos.PlanModels
{
    public class PlanmProductDto
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public int ParentCategoryId { get; set; }
        public string ProductImage { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateAvailable { get; set; }
        public bool Published { get; set; }
        public bool Discontinued { get; set; }
        public bool Hero { get; set; }
        public IEnumerable<PlanmShadeDto> Shades { get; set; }
        public List<int> CountryIds { get; set; }
    }
}
