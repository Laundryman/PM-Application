using Ardalis.Specification;
using PMApplication.Entities.CountriesAggregate;
using PMApplication.Specifications.Filters;

namespace PMApplication.Specifications
{
    public class RegionSpecification : Specification<Region>
    {
        public RegionSpecification(RegionFilter filter)
        {
            Query.OrderBy(x => x.Name);

            if (filter.IsPagingEnabled)
                Query.Skip(PaginationHelper.CalculateSkip(filter))
                    .Take(PaginationHelper.CalculateTake(filter));

            if ((filter.BrandId != null))
                Query.Where(x => x.BrandId == filter.BrandId);

        }

    }
}
