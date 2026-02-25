namespace PMApplication.Dtos.PagedLists
{
    public partial class PagedShadesListDto
    {
        public Page? Page { get; set; }
        public List<ShadeDto>? Data { get; set; }
    }
}
