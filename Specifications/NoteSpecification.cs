using Ardalis.Specification;
using PMApplication.Entities;
using PMApplication.Entities.PlanogramAggregate;
using PMApplication.Specifications.Filters;

namespace PMApplication.Specifications
{
    public class NoteSpecification : Specification<PlanogramNote>
    {
        public NoteSpecification(NoteFilter filter)
        {
            //if (filter.BrandId != null)
            //    Query.Where(x => x.BrandId == filter.BrandId);
            if (filter.PlanogramId != null)
                Query.Where(x => x.PlanogramId == filter.PlanogramId);

            Query.OrderBy(x => x.NoteDate);
        }

    }
}
