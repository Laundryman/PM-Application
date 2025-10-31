using Ardalis.Specification;
using PMApplication.Entities;
using PMApplication.Entities.PlanogramAggregate;
using PMApplication.Specifications.Filters;

namespace PMApplication.Specifications
{
    public class GetPlanogramShelvesSpecification : Specification<PlanogramShelf>
    {
        public GetPlanogramShelvesSpecification(PlanogramFilter filter)
        {
            if (filter.Id != 0)
            {
                Query.Where(x => (x.PlanogramId == filter.Id) && (x.ScratchPadId == null || x.ScratchPadId == 0))
                    //.Include(p => p.)
                    .Include(p => p.Part);
                //.ThenInclude(p => p.Products);

            }

        }

    }
}
