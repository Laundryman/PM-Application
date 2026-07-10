using Ardalis.Specification;
using LinqKit;
using Microsoft.Graph.Models;
using PMApplication.Entities.ClusterAggregate;
using PMApplication.Entities.PartAggregate;
using PMApplication.Entities.ProductAggregate;
using PMApplication.Entities.StandAggregate;
using PMApplication.Specifications.Filters;

namespace PMApplication.Specifications
{
    public class ClusterSpecification : Specification<Cluster>
    {
        public ClusterSpecification(ClusterFilter filter)
        {
            Query.OrderBy(x => x.Name);
            Query.Include(x => x.Stand)
                .ThenInclude(s => s.StandType);
            //int brandId, int? regionId, int? countryId, int? categoryId, int? parentCategoryId, int? partId, bool shoppable

            if (filter.IsPagingEnabled)
                Query.Skip(PaginationHelper.CalculateSkip(filter))
                    .Take(PaginationHelper.CalculateTake(filter));

            if (filter.IncludeShelves == true)
            {
                Query.Include(c => c.ClusterShelves);
                    //.ThenInclude(s => s.Parts);
            }
            if (filter.BrandId != null)
                Query.Where(x => x.BrandId == filter.BrandId);

            if (filter.StandId != null)
                Query.Where(x => x.StandId == filter.StandId);

            if ((filter.StandTypeId != null))
                Query.Where(x => x.Stand.StandTypeId == filter.StandTypeId);

            if (filter.CountryId != null)
            {
                var predicate = PredicateBuilder.New<Cluster>(false);
                predicate = predicate.Or(x => x.CountriesList != null && x.CountriesList.Contains(filter.CountryId.ToString()));
                Query.Where(predicate);
            }

            if (filter.Published != null)
            {
                Query.Where(x => x.Published == filter.Published);
            }

            if (filter.Id != 0)
            {
                Query.Where(c => c.Id == filter.Id)
                    .Include(c => c.Stand);
            }
        }
    }
}
