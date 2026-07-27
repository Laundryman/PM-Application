using Ardalis.Specification;
using PMApplication.Entities.PartAggregate;
using PMApplication.Entities.PlanogramAggregate;
using PMApplication.Enums;
using PMApplication.Specifications.Filters;

namespace PMApplication.Specifications
{
    public class PlanogramPreviewSpecification : Specification<PlanogramPreview>
    {
        public PlanogramPreviewSpecification(PlanogramFilter filter)
        {

                Query.Where(x => x.PlanogramId == filter.Id);

        }

    }
}
