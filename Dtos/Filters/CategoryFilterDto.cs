namespace PMApplication.Dtos.Filters
{
    public class CategoryFilterDto
    {
        public int? Id { get; set; }
        public bool GetParents { get; set; }
        public int? ParentCatId { get; set; }
        public bool LoadChildren { get; set; }
    }
}
