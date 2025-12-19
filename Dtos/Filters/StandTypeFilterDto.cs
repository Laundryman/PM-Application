namespace PMApplication.Dtos.Filters
{
    public class StandTypeFilterDto
    {
        public int? Id { get; set; }
        public int? BrandId { get; set; }
        public int? ParentStandTypeId { get; set; }
        public bool GetParents { get; set; }
    }
}
