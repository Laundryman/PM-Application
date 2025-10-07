namespace PMApplication.Specifications.Filters
{
    public class OrderWindowFilter : BaseFilter
    {

        public int? BrandId { get; set; }
        public bool IncludeExpired { get; set; }
        public bool GetFutureWindows { get; set; }

    }
}
