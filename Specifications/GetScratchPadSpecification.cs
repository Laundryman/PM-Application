using Ardalis.Specification;
using PMApplication.Entities;
using PMApplication.Entities.PlanogramAggregate;
using PMApplication.Specifications.Filters;

namespace PMApplication.Specifications
{
    public class GetScratchPadSpecification : Specification<Planogram>
    {
        public GetScratchPadSpecification(PlanogramFilter filter)
        {
            if (filter.Id != 0)
                Query.Where(x => x.Id == filter.Id)
                    .Include(s => s.PlanogramShelves)
                    .Include(s => s.PlanogramParts);

        }

    }
}
