namespace PMApplication.Dtos.Filters
{
    public class RegionsFilterDto
    {
        public int? BrandId { get; set; }
        public string? IdList { get; set; }
        public bool LoadChildren { get; set; }
        public bool? IncludeDeleted { get; set; }
    }
}
