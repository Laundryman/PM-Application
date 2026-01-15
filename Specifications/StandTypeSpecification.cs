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
            Query.Include(st => st.Stands)
                .Include(st => st.Brand);
            Query.OrderBy(x => x.Name);


            if (filter.BrandId != null && filter.BrandId != 0 && !filter.GetParents)
                Query.Where(x => x.BrandId == filter.BrandId);
                

            if ((filter.ParentStandTypeId != null))
                Query.Where(x => x.ParentStandTypeId == filter.ParentStandTypeId);

            if (filter.GetParents)
            {
                if (filter.BrandId != 0 && filter.BrandId != null)
                {
                    Query.Where(st => st.ParentStandTypeId == 0 || st.ParentStandTypeId == null)
                        .Include(st => st.ChildStandTypes.Where(s => s.BrandId == filter.BrandId))
                        .ThenInclude(st => st.Stands)
                        .Include(st => st.Brand);
                }
                else
                {
                    Query.Where(st => st.ParentStandTypeId == 0 || st.ParentStandTypeId == null)
                        .Include(st => st.ChildStandTypes)
                        .ThenInclude(st => st.Stands)
                        .Include(st => st.Brand);
                }
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
