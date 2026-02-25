namespace PMApplication.Dtos.PagedLists
{
    public partial class PagedRegionListDto
    {
        public Page? Page { get; set; }
        public List<RegionDto>? Data { get; set; }
    }
}
