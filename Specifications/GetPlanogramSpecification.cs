using Ardalis.Specification;
using PMApplication.Entities;
using PMApplication.Entities.PlanogramAggregate;
using PMApplication.Specifications.Filters;

namespace PMApplication.Specifications
{
    public class GetPlanogramSpecification : Specification<Planogram>
    {
        public GetPlanogramSpecification(PlanogramFilter filter)
        {
            if (filter.Id != 0)
                Query.Where(x => x.Id == filter.Id)
                    .Include(x => x.PlanogramNotes)
                    .Include(x => x.Stand)
                    .Include(x => x.PlanogramPartFacings)
                    .Include(x => x.PlanogramParts)
                    .Include(x => x.PlanogramShelves)
                    .Include(x => x.ScratchPad)
                    .ThenInclude(s => s.PlanogramShelves)
                    .Include(x => x.ScratchPad)
                    .ThenInclude(s => s.PlanogramParts);

        }

    }
}
