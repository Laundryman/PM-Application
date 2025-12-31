using Microsoft.Graph.Solutions.BackupRestore.DriveProtectionUnitsBulkAdditionJobs.Item;

namespace PMApplication.Specifications.Filters
{
    public class RegionFilter : BaseFilter
    {
        public int? BrandId { get; set; }
        public int? CountryId { get; set; }
        public int? Id { get; set; }
        public bool LoadChildren { get; set; }
        //public bool IsPagingEnabled { get; set; }
        //public int Page { get; set; }
        //public int PageSize { get; set; }
    }
}
