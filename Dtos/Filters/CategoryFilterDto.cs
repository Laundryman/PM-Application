namespace PMApplication.Dtos.Filters
{
    public class CategoryFilterDto
    {
        public int? Id { get; set; }
        public bool GetParents { get; set; }
        public int? ParentCatId { get; set; }
        public int? BrandId { get; set; }
        public bool LoadChildren { get; set; }
        public bool IsPagingEnabled { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}
