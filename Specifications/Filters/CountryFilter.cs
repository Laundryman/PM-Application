namespace PMApplication.Specifications.Filters
{
    public class CountryFilter : BaseFilter
    {
        public int? RegionId { get; set; }
        public int? BrandId { get; set; }
        public string? IsoCode { get; set; }

        public string? CountryList { get; set; }
    }
}
