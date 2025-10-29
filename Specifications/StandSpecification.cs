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

            if (filter.Id != 0)
            {
                Query.Where(x => x.Id == filter.Id)
                    .Include(x => x.StandType)
                    .ThenInclude(st => st.ParentStandType)
                    .Include(x => x.ColumnList)
                    .ThenInclude(x => x.StandColumnUprights)
                    .Include(x => x.RowList);
            }

            //int brandId, int? regionId, int? countryId, int? categoryId, int? parentCategoryId, int? partId, bool shoppable

            if (filter.IsPagingEnabled)
                Query.Skip(PaginationHelper.CalculateSkip(filter))
                    .Take(PaginationHelper.CalculateTake(filter));

            if (filter.BrandId != 0)
                Query.Where(x => x.BrandId == filter.BrandId);

            if ((filter.ParentStandTypeId != 0))
                Query.Where(x => x.ParentStandTypeId == filter.ParentStandTypeId);

            if ((filter.StandTypeId != 0))
                Query.Where(x => x.StandTypeId == filter.StandTypeId);

            if ((filter.Discontinued ))
                Query.Include(x => x.Discontinued == filter.Discontinued);

            if ((filter.CountryId != 0))
            {
                Query.Include(x => x.Countries
                        .Where(x => x.Id == filter.CountryId));

            }
        }
    }
}
