using Ardalis.Specification;
using PMApplication.Entities.PartAggregate;
using PMApplication.Enums;
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

            if (filter.Id != null)
            {
                Query.Include(p => p.Products)
                    .ThenInclude(p => p.Shades);
                Query.Where(p => p.Id == filter.Id);
            }

            if (!string.IsNullOrEmpty(filter.PartNumber))
                Query.Where(x => x.PartNumber == filter.PartNumber);

            if ((filter.PartTypeId != null))
                Query.Where(x => x.PartTypeId == filter.PartTypeId);
            if ((filter.BrandId != null))
                Query.Where(x => x.BrandId == filter.BrandId);
            if ((filter.ParentCategoryId != null))
                Query.Where(x => x.ParentCategoryId == filter.ParentCategoryId);
            if ((filter.CategoryId != null))
                Query.Where(x => x.CategoryId == filter.CategoryId);
            if((filter.ParentCategoryId != null))
                Query.Where(x => x.ParentCategoryId == filter.ParentCategoryId);
            if (filter.Countries != null)
            {
                if (filter.Countries.Count > 0)
                {
                    var countryIds = filter.Countries.Select(c => c.Id).ToList();
                    Query.Where(p => p.Countries.Any(c => countryIds.Contains(c.Id)));
                }
            }

            if (filter.StandTypeId != null)
                Query.Where(x => x.StandTypes.Any( s => s.Id == filter.StandTypeId));
            if (filter.excludeSpareParts)
            {
                Query.Where(p => p.PartTypeId != (int)PartTypeEnum.SparePart);
            }

        }

    }
}
