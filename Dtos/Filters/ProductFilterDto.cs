namespace PMApplication.Dtos.Filters
{
    public class ProductFilterDto
    {
        public int BrandId { get; set; }
        public int PartId { get; set; }
        public int? RegionId { get; set; }
        public int? CountryId { get; set; }
        public int? CategoryId { get; set; }
        public string? CountriesList { get; set; }
        //public int? ParentCategoryId { get; set; }
        //public int PartTypeId { get; set; }

        //public bool LoadChildren { get; set; }
        //public bool IsPagingEnabled { get; set; }
        //public int Page { get; set; }
        //public int PageSize { get; set; }
    }
}
