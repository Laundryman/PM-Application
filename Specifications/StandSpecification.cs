using Ardalis.Specification;
using Microsoft.Graph.Models;
using PMApplication.Entities.PartAggregate;
using PMApplication.Entities.StandAggregate;
using PMApplication.Specifications.Filters;

namespace PMApplication.Specifications
{
    public class StandSpecification : Specification<Stand>
    {
        public StandSpecification(StandFilter filter)
        {
            Query.OrderBy(x => x.Name)
                .ThenByDescending(x => x.StandTypeId);

            //int brandId, int? regionId, int? countryId, int? categoryId, int? parentCategoryId, int? partId, bool shoppable

            if (filter.IsPagingEnabled)
                Query.Skip(PaginationHelper.CalculateSkip(filter))
                    .Take(PaginationHelper.CalculateTake(filter));

            if (filter.BrandId != null)
                Query.Where(x => x.BrandId == filter.BrandId);

            if ((filter.ParentStandTypeId != null))
                Query.Include(x => x.ParentStandTypeId == filter.ParentStandTypeId);

            if ((filter.StandTypeId != null))
                Query.Include(x => x.StandTypeId == filter.StandTypeId);

            if ((filter.Discontinued != null))
                Query.Include(x => x.Discontinued == filter.Discontinued);

            if ((filter.CountryId != null))
            {
                Query.Include(x => x.Countries)
                    .Where(x => x.Countries.All(c => c.Id == filter.CountryId));
            }
        }
    }
}
