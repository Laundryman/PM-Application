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
            if (filter.Id != 0)
            {
                Query.Where(x => x.Id == filter.Id);
            }
            if (filter.BrandId != 0)
                Query.Where(x => x.BrandId == filter.BrandId);
            if (!String.IsNullOrEmpty(filter.UserId))
                Query.Where(x => x.UserId == filter.UserId);

            if (filter.LoadRelatedEntities == true)
            {
                Query.Include(x => x.Stand)
                    .ThenInclude(x => x.ColumnList)
                     .Include(x => x.Job)
                     .Include(x => x.ScratchPad)
                     .Include(x => x.PlanogramNotes)
                     .Include(x => x.Stand);

                     //.Include(x => x.PlanogramParts)
                     //.ThenInclude(x => x.PlanogramPartFacings)
                     //.ThenInclude(p => p.Part)
                     //.Include(x => x.PlanogramShelves);
                     //.ThenInclude(s => s.Part);
            }

            Query.OrderBy(x => x.Name);
        }

    }
}
