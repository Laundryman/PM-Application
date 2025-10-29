using Ardalis.Specification;
using PMApplication.Entities;
using PMApplication.Entities.PlanogramAggregate;
using PMApplication.Specifications.Filters;

namespace PMApplication.Specifications
{
    public class GetScratchPadSpecification : Specification<ScratchPad>
    {
        public GetScratchPadSpecification(ScratchPadFilter filter)
        {
            if (filter.Id != 0)
                Query.Where(x => x.Id == filter.Id)
                    .Include(s => s.PlanogramShelves)


                    .Include(s => s.PlanogramParts)
                    .ThenInclude(p => p.PlanogramPartFacings)
                    //.ThenInclude(f => f.Product)

                    .Include(s => s.PlanogramParts)
                    .ThenInclude(p => p.Products)

                    .Include(s => s.PlanogramParts)
                    .ThenInclude(p => p.Part)
                    .ThenInclude(p => p.Products)
                    .ThenInclude(p => p.Product)
                    .ThenInclude(p => p.Shades)

                    .Include(s => s.PlanogramParts)
                    .ThenInclude(p => p.Part)
                    .ThenInclude(p => p.Countries)

                    .Include(s => s.PlanogramParts)
                    .ThenInclude(p => p.Part)
                    .ThenInclude(p => p.Products);
        }

    }
}
