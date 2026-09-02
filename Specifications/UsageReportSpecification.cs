using Ardalis.Specification;
using PMApplication.Dtos.Filters;
using PMApplication.Entities;
using PMApplication.Specifications.Filters;

namespace PMApplication.Specifications
{
    public class UsageReportSpecification : Specification<AuditLog>
    {
        public UsageReportSpecification(ReportingFilterDto filter)
        {
            if (filter.BrandId != 0)
                Query.Where(x => x.Id == filter.BrandId);

            if (filter.RegionId != null && filter.RegionId != 0)
                Query.Where(x => x.RegionId == filter.RegionId);

            if (filter.CountryId != null && filter.CountryId != 0)
                Query.Where(x => x.CountryId == filter.CountryId);

            if (filter.StartDate != null && filter.EndDate != null)
                Query.Where(x => x.Date >= filter.StartDate && x.Date <= filter.EndDate);

            if (filter.RoleId != 0)
                Query.Where(x => x.RoleId == filter.RoleId);

            if (filter.ActionType != 0)
                Query.Where(x => x.ActionType == filter.ActionType);

            if (filter.ActionId != 0)
                Query.Where(x => x.Action == filter.ActionId);

            Query.OrderByDescending(x => x.Date);
        }

    }
}
