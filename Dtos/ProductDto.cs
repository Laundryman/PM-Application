using PMApplication.Dtos.PlanModels;
using PMApplication.Entities;

namespace PMApplication.Dtos
{
    public class ProductDto
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? ShortDescription { get; set; }
        public string? FullDescription { get; set; }
        public int? BrandId { get; set; }
        public int? CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public string? DateCreated { get; set; }
        public string? DateUpdated { get; set; }
        public string? DateAvailable { get; set; }
        public bool Published { get; set; }
        public string? ProductImage { get; set; }
        public bool? Discontinued { get; set; }
        public bool Hero { get; set; }
        public int? ParentCategoryId { get; set; }
        public string? ParentCategoryName { get; set;}
        public string? CountriesList { get; set; }
        public string? RegionsList { get; set; }
        public IEnumerable<PlanmShadeDto>? Shades { get; set; }
        public ICollection<RegionDto>? Regions { get; set; }
        public IEnumerable<CountryDto>? Countries { get; set; }


    }
}
