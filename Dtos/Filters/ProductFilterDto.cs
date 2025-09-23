namespace PMApplication.Dtos.Filters
{
    public class ProductFilterDto
    {
        public int? CategoryId { get; set; }
        public int? BrandId { get; set; }
        public string CountryList { get; set; }
        public int? ParentCategoryId { get; set; }
        public int PartTypeId { get; set; }
        public int? RegionId { get; set; }

        public bool LoadChildren { get; set; }
        public bool IsPagingEnabled { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}
