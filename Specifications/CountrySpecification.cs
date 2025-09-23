using Ardalis.Specification;
using LinqKit;
using PMApplication.Entities.CountriesAggregate;
using PMApplication.Specifications.Filters;

namespace PMApplication.Specifications
{
    public class CountrySpecification : Specification<Country>
    {
        public CountrySpecification(CountryFilter filter)
        {
            Query.OrderBy(x => x.Name);

            if (filter.CountryList != null)
            {
                var requiredCountries = filter.CountryList.Split(",").ToList();
                var predicate = PredicateBuilder.New<Country>(false);
                foreach (var country in requiredCountries)
                {
                    predicate = predicate.Or(x => x.Id.ToString() == country);
                }
                Query.Where(predicate);

            }

            if (filter.IsPagingEnabled)
                Query.Skip(PaginationHelper.CalculateSkip(filter))
                    .Take(PaginationHelper.CalculateTake(filter));

            if ((filter.RegionId != null))
                Query.Where(x => x.RegionId == filter.RegionId);

        }

    }
}
