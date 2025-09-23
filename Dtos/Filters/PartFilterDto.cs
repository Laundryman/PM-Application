namespace PMApplication.Dtos.Filters
{
    public partial class PartFilterDto
    {


        public string? RegionId { get; set; }
        public string? CountryId { get; set; }
        public string? PartNumber { get; set; }
        public string? AltPartNumber { get; set; }
        public string? CustomerRefNo { get; set; }
        public int? CategoryId { get; set; }
        public int? ParentCategoryId { get; set; }
        public int? PartTypeId { get; set; }
        public string? PartTypeName { get; set; }
        public int? BrandId { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public bool Published { get; set; }
        public bool LoadChildren { get; set; }
        public bool IsPagingEnabled { get; set; }
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 10;

    }
}
