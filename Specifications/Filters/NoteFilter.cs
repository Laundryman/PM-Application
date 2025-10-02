namespace PMApplication.Specifications.Filters
{
    public class NoteFilter : BaseFilter
    {
        public long? PlanogramId { get; set; }
        public int? BrandId { get; set; }
        public string? UserId { get; set; }
        public int? CountryId { get; set; }
        public int? RegionId { get; set; }

    }
}
