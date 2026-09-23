using Ardalis.Specification;
using LinqKit;
using PMApplication.Entities;
using PMApplication.Entities.PlanogramAggregate;
using PMApplication.Entities.ProductAggregate;
using PMApplication.Dtos.Filters.Widgets;

namespace PMApplication.Specifications.Widgets
{
    public class PlanogramCountSpecification : Specification<Planogram>
    {
        public PlanogramCountSpecification(CountsFilterDto filter)
        {

            if (filter.BrandId != 0 && filter.BrandId != null)
                Query.Where(x => x.BrandId == filter.BrandId);
            //if (!String.IsNullOrEmpty(filter.UserId))
            //    Query.Where(x => x.UserId == filter.UserId);
            if (filter.RecentFromDate != null)
                Query.Where(x => x.DateCreated >= filter.RecentFromDate);

            //if (filter.CountriesList != null)
            //{
            //    var requiredCountries = filter.CountriesList.Split(",").ToList();
            //    var predicate = PredicateBuilder.New<Planogram>(false);
            //    foreach (var country in requiredCountries)
            //    {
            //        predicate = predicate.Or(x => x.CountryId != null && x.CountryId == int.Parse(country));
            //    }
            //    Query.Where(predicate);

            //}

        }

    }
}
