namespace PMApplication.Dtos
{
    public partial class Page
    {
        public int TotalItems { get; set; }
        public int TotalPages { get; set; }
        public int PageNumber { get; set; }
        public int Size { get; set; }
    }
}
