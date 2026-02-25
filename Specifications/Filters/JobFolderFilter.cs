namespace PMApplication.Specifications.Filters
{
    public class JobFolderFilter
    {
        public int? BrandId { get; set; } = 0;
        public int? Id { get; set; } = 0;
        public int? CountryId { get; set; } = 0;
        public int? RegionId { get; set; } = 0;
        public bool? HasJobs { get; set; }
    }
}
