using Ardalis.Specification;
using PMApplication.Entities.PartAggregate;
using PMApplication.Specifications.Filters;

namespace PMApplication.Specifications
{
    public class PartSpecification : Specification<Part>
    {
        public PartSpecification(PartFilter filter)
        {
            Query.OrderBy(x => x.Name)
                    .ThenByDescending(x => x.PartNumber);

            //if (filter.LoadChildren)
            //    Query.Include(x => x.Stores);

            if (filter.IsPagingEnabled)
                Query.Skip(PaginationHelper.CalculateSkip(filter))
                     .Take(PaginationHelper.CalculateTake(filter));

            if (!string.IsNullOrEmpty(filter.PartNumber))
                Query.Where(x => x.PartNumber == filter.PartNumber);

            if ((filter.PartTypeId != null))
                Query.Where(x => x.PartTypeId == filter.PartTypeId);
            if ((filter.BrandId != null))
                Query.Where(x => x.BrandId == filter.BrandId);
            if ((filter.ParentCategoryId != null))
                Query.Where(x => x.ParentCategoryId == filter.ParentCategoryId);

        }

    }
}
