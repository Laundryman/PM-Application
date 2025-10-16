using PMApplication.Dtos;

namespace PMApplication.Specifications.Filters
{
    public class PlanogramLockFilter : BaseFilter
    {
        public long? PlanogramId { get; set; }
        public CurrentUser? User { get; set; }
    }
}
