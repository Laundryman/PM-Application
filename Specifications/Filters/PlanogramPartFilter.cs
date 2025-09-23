namespace PMApplication.Specifications.Filters
{
    public class PlanogramPartFilter : BaseFilter
    {
        public long? PlanogramId { get; set; }
        public int? CountryId { get; set; }
        public long? PartId { get; set; }
    }
}
