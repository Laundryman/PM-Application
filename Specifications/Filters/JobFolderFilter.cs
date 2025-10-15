namespace PMApplication.Specifications.Filters
{
    public class JobFolderFilter : BaseFilter
    {
        public int BrandId { get; set; } = 0;
        public int JobFolderId { get; set; } = 0;
        public int CountryId { get; set; } = 0;
        public int RegionId { get; set; } = 0;
        public bool HasJobs { get; set; }
    }
}
