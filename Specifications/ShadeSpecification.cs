using Ardalis.Specification;
using LinqKit;
using Microsoft.EntityFrameworkCore;
using PMApplication.Entities;
using PMApplication.Specifications.Filters;

namespace PMApplication.Specifications
{
    public class ShadeSpecification : Specification<Shade>
    {
        public ShadeSpecification(ShadeFilter filter)
        {
            if (filter.Published)
                Query.Where(x => x.Published == true);

            if (filter.ShadeNumber != null)
            {
                Query.Where(x => x.ShadeNumber == filter.ShadeNumber);
            }
            //if (filter.PartId != null)
            //    Query.Where(x => x.PartProducts.All(p => p.PartId == filter.PartId));

            if ((filter.ProductId != null))
                Query.Where(x => x.ProductId == filter.ProductId);


            if (filter.CountryList != null)
            {
                var requiredCountries = filter.CountryList.Split(",").ToList();
                var predicate = PredicateBuilder.New<Shade>(false);
                foreach (var country in requiredCountries)
                {
                    predicate = predicate.Or(x => x.CountryList.Contains(country));
                }
                Query.Where(predicate);

            }

            if (filter.Country != null)
            {
                Query.Where(x => x.Countries.Contains(filter.Country));
            }
            Query.OrderBy(x => x.ShadeNumber);

            var baseFilter = new BaseFilter();

            if (filter.IsPagingEnabled)
                Query.Skip(PaginationHelper.CalculateSkip(filter))
                    .Take(PaginationHelper.CalculateTake(filter));


        }

    }
}
