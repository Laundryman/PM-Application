using Ardalis.Specification;
using PMApplication.Entities;
using PMApplication.Entities.PlanogramAggregate;
using PMApplication.Specifications.Filters;

namespace PMApplication.Specifications
{
    public class GetPlanogramPartsSpecification : Specification<PlanogramPart>
    {
        public GetPlanogramPartsSpecification(PlanogramPartFilter filter)
        {
            if (filter.PlanogramId != 0)
            {
                Query.Where(x => (x.PlanogramId == filter.PlanogramId) && (x.ScratchPadId == null))
                    .Include(p => p.PlanogramPartFacings)
                    .Include(p => p.Products)

                    .Include(x => x.Part)
                    //.ThenInclude(p => p.Countries)

                    .Include(p => p.Part)
                    .ThenInclude(p => p.Products)
                    .ThenInclude(pp => pp.Product)
                    //.ThenInclude(p => p.Countries)

                    .OrderBy(p => p.PositionX).ThenBy(p => p.PositionY);
                //.ThenInclude(p => p.Countries)

            }

            if (filter.NewParts)
            {
                Query.Where(x => x.DateUpdated == null);
            }

            if (filter.PartId != 0)
            {
                Query.Where(x => x.PlanogramPartPlanogramPartsId == filter.PartId);
            }
        }

    }
}
