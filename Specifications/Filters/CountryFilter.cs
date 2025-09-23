namespace PMApplication.Specifications.Filters
{
    public class CountryFilter : BaseFilter
    {
        public int? RegionId { get; set; }
        public string? CountryList { get; set; }
        public bool LoadChildren { get; set; }
        public bool IsPagingEnabled { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}
