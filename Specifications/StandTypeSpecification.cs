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
                .ThenByDescending(x => x.ParentStandTypeId)
                .Include(st => st.Stands);

            if (filter.BrandId != null)
                Query.Where(x => x.BrandId == filter.BrandId);

            if ((filter.ParentStandTypeId != null))
                Query.Include(x => x.ParentStandTypeId == filter.ParentStandTypeId);

            if (filter.GetParents)
            {
                Query.Where(st => st.ParentStandTypeId == 0 || st.ParentStandTypeId == null)
                    .Include(st => st.ChildTypes);
            }

            //if (filter.IsPagingEnabled)
            //    Query.Skip(PaginationHelper.CalculateSkip(filter))
            //        .Take(PaginationHelper.CalculateTake(filter));

            //if (filter.HasStands)
            //{
            //    Query.Include(x => x.Stands.Any());
            //}

        }
    }
}
