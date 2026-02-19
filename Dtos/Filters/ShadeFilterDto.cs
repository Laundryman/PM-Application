namespace PMApplication.Dtos.Filters
{
    public class ShadeFilterDto
    {
        public int BrandId { get; set; }
        public string? ShadeNumber { get; set; }
        public string? ShadeDescription { get; set; }
        public int ProductId { get; set; }
        public bool Published { get; set; }
        public string? CountryList { get; set; }
        public bool LoadChildren { get; set; }
        public bool IsPagingEnabled { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}
