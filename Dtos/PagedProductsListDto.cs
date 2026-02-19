namespace PMApplication.Dtos
{
    public partial class PagedProductsListDto
    {
        public Page? Page { get; set; }
        public List<ProductDto>? Data { get; set; }
    }
}
