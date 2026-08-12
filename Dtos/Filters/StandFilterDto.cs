namespace PMApplication.Dtos.Filters
{
    public class StandFilterDto
    {
        public int? Id { get; set; }
        public int? BrandId { get; set; }
        public int? RegionId { get; set; }
        public int? CountryId { get; set; }
        public int? StandTypeId { get; set; }

        //public int? CategoryId { get; set; }
        public string? RegionIds { get; set; }
        public string? CountryIds { get; set; }
        //public int? ParentCategoryId { get; set; }
        //public int PartTypeId { get; set; }

        //public bool LoadChildren { get; set; }
        //public bool IsPagingEnabled { get; set; }
        //public int Page { get; set; }
        //public int PageSize { get; set; }
    }
}
