namespace PMApplication.Specifications.Filters
{
    public class CategoryFilter : BaseFilter
    {
        public int Id { get; set; } = 0;
        public int ParentCatId { get; set; } = 0;
        public bool GetParents { get; set; }
        public int? BrandId { get; set; }
    }
}
