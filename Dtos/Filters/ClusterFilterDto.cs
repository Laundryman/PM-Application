namespace PMApplication.Dtos.Filters
{
    public class ClusterFilterDto
    {
        public int BrandId { get; set; }
        public int RegionId { get; set; } = 0;

        public int CountryId { get; set; } = 0;
        //public int? CategoryId { get; set; }
        //public string CountriesList { get; set; }
        //public int? ParentCategoryId { get; set; }
        //public int PartTypeId { get; set; }

        //public bool LoadChildren { get; set; }
        //public bool IsPagingEnabled { get; set; }
        //public int Page { get; set; }
        //public int PageSize { get; set; }
    }
}
