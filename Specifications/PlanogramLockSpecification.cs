using Ardalis.Specification;
using PMApplication.Entities.PartAggregate;
using PMApplication.Entities.PlanogramAggregate;
using PMApplication.Enums;
using PMApplication.Specifications.Filters;

namespace PMApplication.Specifications
{
    public class PlanogramLockSpecification : Specification<PlanogramLock>
    {
        public PlanogramLockSpecification(PlanogramLockFilter filter)
        {

            if (filter.PlanogramId != null)
                Query.Where(x => x.PlanogramId == filter.PlanogramId);

            if ((filter.User != null))
                Query.Where(x => x.UserId != filter.User.Id);
        }

    }
}
