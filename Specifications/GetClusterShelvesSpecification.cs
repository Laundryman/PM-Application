using Ardalis.Specification;
using PMApplication.Entities;
using PMApplication.Entities.ClusterAggregate;
using PMApplication.Entities.PlanogramAggregate;
using PMApplication.Specifications.Filters;

namespace PMApplication.Specifications
{
    public class GetClusterShelvesSpecification : Specification<ClusterShelf>
    {
        public GetClusterShelvesSpecification(ClusterFilter filter)
        {
            if (filter.Id != 0)
            {
                Query.Where(x => (x.ClusterId == filter.Id))
                    //.Include(p => p.)
                    .Include(p => p.Part)
                    .ThenInclude(p => p.PartType);
                //.ThenInclude(p => p.Products);

            }

        }

    }
}
