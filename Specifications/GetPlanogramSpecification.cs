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
            {
                Query.Where(x => x.Id == filter.Id)
                    //.Include(x => x.PlanogramNotes)
                    .Include(x => x.Stand)
                    .ThenInclude(s => s.ColumnList)
                    .Include(x => x.Stand)
                    .ThenInclude(s => s.RowList);

                //.Include(x => x.PlanogramPartFacings)
                //.Include(x => x.PlanogramParts)
                //.ThenInclude(p => p.PlanogramPartFacings)
                //.Include(x => x.PlanogramParts)
                //.ThenInclude(p => p.Products)

                //.Include(x => x.PlanogramParts)
                //.ThenInclude(p => p.Countries)
                //.Include(x => x.PlanogramParts)
                //.ThenInclude(p => p.Part)
                //.ThenInclude(p => p.Products)

                //.ThenInclude(p => p.Countries)

                //.Include(x => x.PlanogramShelves)
                //.ThenInclude(p => p.Part)
                ////.ThenInclude(p => p.Countries)

                //.Include(x => x.ScratchPad)
                //.ThenInclude(s => s.PlanogramShelves)
                //.Include(x => x.ScratchPad)
                //.ThenInclude(s => s.PlanogramParts);
            }

        }

    }
}
