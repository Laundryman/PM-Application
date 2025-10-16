using Ardalis.Specification;
using PMApplication.Entities.PartAggregate;
using PMApplication.Entities.PlanogramAggregate;
using PMApplication.Specifications.Filters;

namespace PMApplication.Specifications
{
    public class PlanogramPartFilterSpecification : Specification<PlanogramPart>
    {
        public PlanogramPartFilterSpecification(PlanogramPartFilter filter)
        {

            Query.OrderBy(x => x.PlanogramId)
                .ThenByDescending(x => x.PlanogramId);

            //if (filter.LoadChildren)
            //    Query.Include(x => x.Stores);

            if (filter.IsPagingEnabled)
                Query.Skip(PaginationHelper.CalculateSkip(filter))
                    .Take(PaginationHelper.CalculateTake(filter));

            if (filter.PlanogramId != null)
                Query.Where(x => x.PlanogramId == filter.PlanogramId);

            if ((filter.CountryId != null))
            {
                Query.Include(x => x.Countries)
                    .Where(x => x.Countries.All(c => c.Id == filter.CountryId ));
            }

            if (filter.PartId != null)
                Query.Where(x => x.Part.Id == filter.PartId);

        }
    }
}
