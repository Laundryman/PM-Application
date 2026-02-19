namespace PMApplication.Dtos.Categories
{
    public class ParentCategoryDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int DisplayOrder { get; set; }
        public int? ParentCategoryId { get; set; }

        public int? HeroProductId { get; set; }
        public string? HeroImageUrl { get; set; }
        public List<CategoryDto> SubCategories { get; set; } = new List<CategoryDto>();

    }
}
