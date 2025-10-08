using Ardalis.Specification;
using Microsoft.Graph.Models;
using PMApplication.Entities.CountriesAggregate;
using PMApplication.Entities.PartAggregate;
using PMApplication.Entities.StandAggregate;
using PMApplication.Specifications.Filters;

namespace PMApplication.Specifications
{
    public class StandTypeSpecification : Specification<StandType>
    {
        public StandTypeSpecification(StandTypeFilter filter)
        {
            Query.OrderBy(x => x.Name)
                .ThenByDescending(x => x.ParentStandTypeId);

            //int brandId, int? regionId, int? countryId, int? categoryId, int? parentCategoryId, int? partId, bool shoppable

            if (filter.IsPagingEnabled)
                Query.Skip(PaginationHelper.CalculateSkip(filter))
                    .Take(PaginationHelper.CalculateTake(filter));

            if (filter.BrandId != null)
                Query.Where(x => x.BrandId == filter.BrandId);

            if ((filter.ParentStandTypeId != null))
                Query.Include(x => x.ParentStandTypeId == filter.ParentStandTypeId);


            if (filter.CountryId != null)
            {

                Query.Where(x =>
                    x.Stands.Any(st => st.Countries.Any(country => country.Id == filter.CountryId)));
            }

            if (filter.HasStands)
            {
                Query.Include(x => x.Stands.Any());
            }

        }
    }
}
