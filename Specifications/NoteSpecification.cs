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
            Query.Where(x => x.NoteInReplyTo == null);
            //if (filter.BrandId != null)
            //    Query.Where(x => x.BrandId == filter.BrandId);
            if (filter.PlanogramId != null)
                Query.Where(x => x.PlanogramId == filter.PlanogramId)
                    .Include(x => x.PlanogramNotes);
                    //.Include(x => x.PlanogramNoteInReplyTo);
                

            Query.OrderBy(x => x.NoteDate);
        }

    }
}
