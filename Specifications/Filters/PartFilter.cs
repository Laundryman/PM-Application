using PMApplication.Dtos;

namespace PMApplication.Specifications.Filters
{
    public class PartFilter : BaseFilter
    {
        public string PartNumber { get; set; }
        public int? PartTypeId { get; set; }
        public int? StandTypeId { get; set; }
        public short? Facings { get; set; }
        public int? RegionId { get; set; }
        public int? CountryId { get; set; }
        public string AltPartNumber { get; set; }
        public string CustomerRefNo { get; set; }
        public int? CategoryId { get; set; }
        public int? ParentCategoryId { get; set; }
        public int? BrandId { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public bool Published { get; set; }
        public string? sortBy { get; set; }
        public string? sortOrder { get; set; }
        public string? SearchString { get; set; }
        public bool excludeSpareParts { get; set; }
        public ICollection<CountryDto> Countries { get; set; }

    }
}
