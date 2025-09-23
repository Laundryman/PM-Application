namespace PMApplication.Dtos.Filters
{
    public class RegionsFilterDto
    {
        public int? BrandId { get; set; }
        public bool LoadChildren { get; set; }
        public bool IsPagingEnabled { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}
