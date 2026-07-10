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
                    .Include(p => p.PlanogramPartFacings);
                    //.ThenInclude(pf => pf.Product);
                    //.Include(p => p.Products)
                    //.ThenInclude(s => s.Shades)

                    //.Include(x => x.Part)

                    if (filter.LoadChildren)
                    {
                    Query.Include(p => p.Part)
                        .ThenInclude(p => p.PartType)
                        .Include(p => p.Part)
                        .ThenInclude(p => p.Products)
                        //.ThenInclude(p => p.PartType)
                        //.ThenInclude(prod => prod.Product)
                        .ThenInclude(s => s.Shades);
                        //.Include(f => f.PlanogramPartFacings);
                        //.ThenInclude(p => p.Countries);
                    }
                    else
                {
                    Query.Include(x => x.Part)
                    .ThenInclude(p => p.PartType);

                }


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

            Query.OrderBy(p => p.PositionX).ThenBy(p => p.PositionY);
        }

    }
}
