namespace PMApplication.Dtos
{
    public partial class PagedPartsListDto
    {
        public Page Page { get; set; }
        public List<PartListDto> Data { get; set; }
    }
}
