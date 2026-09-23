namespace PMApplication.Dtos.Filters.Widgets
{
    public class PlanoWidgetFilterDto
    {
        public string? UserId { get; set; }
        public int? BrandId { get; set; }
        //public int? StatusId { get; set; }  
        public bool Archived { get; set; } = false;
        //public int? StandTypeId { get; set; }
        //public bool? Locked { get; set; }
        //public int? RegionId { get; set; }
        //public int? CountryId { get; set; }
        public string? RegionsList { get; set; }
        public string? CountriesList { get; set; }
        public bool IncludeDeleted { get; set; } = false;
    }
}
