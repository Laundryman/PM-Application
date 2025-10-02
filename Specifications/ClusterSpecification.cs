using Ardalis.Specification;
using Microsoft.Graph.Models;
using PMApplication.Entities.ClusterAggregate;
using PMApplication.Entities.PartAggregate;
using PMApplication.Entities.StandAggregate;
using PMApplication.Specifications.Filters;

namespace PMApplication.Specifications
{
    public class ClusterSpecification : Specification<Cluster>
    {
        public ClusterSpecification(ClusterFilter filter)
        {
            Query.OrderBy(x => x.Name);

            //int brandId, int? regionId, int? countryId, int? categoryId, int? parentCategoryId, int? partId, bool shoppable

            if (filter.IsPagingEnabled)
                Query.Skip(PaginationHelper.CalculateSkip(filter))
                    .Take(PaginationHelper.CalculateTake(filter));

            if (filter.BrandId != null)
                Query.Where(x => x.BrandId == filter.BrandId);

            if (filter.StandId != null)
                Query.Where(x => x.StandId == filter.StandId);

            if ((filter.StandTypeId != null))
                Query.Include(x => x.Stand.StandTypeId == filter.StandTypeId);

            if ((filter.CountryId != null))
            {
                Query.Include(x => x.Stand.Countries)
                    .Where(x => x.Stand.Countries.All(c => c.Id == filter.CountryId));
            }

            if (filter.Published != null)
            {
                Query.Where(x => x.Published == filter.Published);
            }
        }
    }
}
