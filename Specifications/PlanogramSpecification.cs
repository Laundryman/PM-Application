using Ardalis.Specification;
using PMApplication.Entities;
using PMApplication.Entities.PlanogramAggregate;
using PMApplication.Specifications.Filters;

namespace PMApplication.Specifications
{
    public class PlanogramSpecification : Specification<Planogram>
    {
        public PlanogramSpecification(PlanogramFilter filter)
        {
            if (filter.BrandId != 0)
                Query.Where(x => x.Id == filter.BrandId);
            if (!String.IsNullOrEmpty(filter.UserId))
                Query.Where(x => x.UserId == filter.UserId);

            Query.OrderBy(x => x.Name);
        }

    }
}
