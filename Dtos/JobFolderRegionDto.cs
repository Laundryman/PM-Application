namespace PMApplication.Dtos
{
    public class JobFolderRegionDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int ZoneId { get; set; }
        public int? BrandId { get; set; }
        public string? CountryList { get; set; }
        public List<JobFolderDto>? JobFolders { get; set; }
        public List<CountryDto>? Countries { get; set; }

    }
}
