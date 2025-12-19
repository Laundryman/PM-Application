namespace PMApplication.Specifications.Filters
{
    public class StandTypeFilter : BaseFilter
    {
        public int? Id { get; set; }
        public string Name { get; set; } = null!;
        public int? ParentStandTypeId { get; set; }
        public int? BrandId { get; set; }
        public bool GetParents { get; set; }
        //public string? Description { get; set; }

        //public int? CountryId { get; set; }

        //public bool Lock { get; set; }

        //public bool HasStands { get; set; }
        //public int? RegionId { get; set; }
        //public bool Shoppable { get; set; }
        //public long PartId { get; set; }
        //public int? CategoryId { get; set; }


    }
}
