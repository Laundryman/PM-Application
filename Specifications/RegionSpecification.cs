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

            if ((filter.BrandId != null) && filter.BrandId != 0)
                Query.Where(x => x.BrandId == filter.BrandId);

            if (!string.IsNullOrEmpty(filter.idList))
            {
                var ids = filter.idList.Split(',').Select(int.Parse).ToList();
                Query.Where(x => ids.Contains(x.Id));
            }

            if (filter.Id != null)
            {
                Query.Where(x => x.Id == filter.Id);
            }
            if (filter.LoadChildren)
            {
                Query.Include(r => r.Countries);
            }
        }

    }
}
