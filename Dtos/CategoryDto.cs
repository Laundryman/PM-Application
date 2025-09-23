namespace PMApplication.Dtos
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public int? ParentCategoryId { get; set; }

        public CategoryDto ParentCategory { get; set;}

        public CategoryDto(string name)
        {
            Name = name;
        }
    }
}
