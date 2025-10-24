namespace PMApplication.Specifications.Filters
{
    public class ProductFilter : BaseFilter
    {
        public int? CategoryId { get; set; }
        public int? ParentCategoryId { get; set; }
        public string CountryList { get; set; }
        public int PartTypeId { get; set; }
        public int? PartId { get; set; }
        public int? CountryId { get; set; }
        public int? BrandId { get; set; }
        public int? RegionId { get; set; }
        public bool IsPublished { get; set; }
        public new bool LoadChildren { get; set; }
        public new bool IsPagingEnabled { get; set; }
        public new int Page { get; set; }
        public new int PageSize { get; set; }
    }
}
