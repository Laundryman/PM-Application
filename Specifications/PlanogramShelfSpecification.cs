using Ardalis.Specification;
using PMApplication.Entities.PartAggregate;
using PMApplication.Entities.PlanogramAggregate;
using PMApplication.Specifications.Filters;

namespace PMApplication.Specifications
{
    public class PlanogramShelfSpecification : Specification<PlanogramShelf>
    {
        public PlanogramShelfSpecification(PlanogramFilter filter)
        {

            Query.OrderBy(x => x.PlanogramId)
                .ThenByDescending(x => x.PlanogramId);

            //if (filter.LoadChildren)
            //    Query.Include(x => x.Stores);


            if (filter.Id != null)
                Query.Where(x => x.PlanogramId == filter.Id)
                    .Include(ps => ps.Part)
                    .Include(ps => ps.PlanogramParts)
                    .ThenInclude(pp => pp.PlanogramPartFacings);

        }
    }
}
