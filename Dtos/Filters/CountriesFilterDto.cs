namespace PMApplication.Dtos.Filters
{
    public class CountriesFilterDto
    {
        public int? RegionId { get; set; }
        public bool LoadChildren { get; set; }
        public bool IsPagingEnabled { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}
