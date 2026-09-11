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

            if (filter.IncludeProducts)
            {
                Query.Include(p => p.Products);
            }
            if (filter.Published)
            {
                Query.Where(p => p.Published);
            }

            if (filter.excludeAccessories)
            {
                Query.Where(p => p.ParentCategoryId != 8 && p.ParentCategoryId != 30 && p.ParentCategoryId != 28);
                
            }
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
            if (filter.RegionId != null && filter.Countries == null && filter.CountryId == null)
            {
                Query.Where(x => x.Regions.Any(r => r.Id == filter.RegionId));

            }

            if (filter.CountryId != null)
            {
                Query.Where(p => p.Countries.Any(c => c.Id == filter.CountryId));
            }
            if (filter.Countries != null)
            {
                if (filter.Countries.Count > 0)
                {
                    var countryIds = filter.Countries.Select(c => c.Id).ToList();
                    Query.Where(p => p.Countries.Any(c => countryIds.Contains(c.Id)));
                }
            }

            if ((filter.ParentCategoryId != null))
                Query.Where(x => x.ParentCategoryId == filter.ParentCategoryId);
            if ((filter.CategoryId != null))
                Query.Where(x => x.CategoryId == filter.CategoryId);

            if (filter.StandTypeId != null)
            {
                //Query.Include(p => p.StandTypes);
                Query.Where(x => x.StandTypes.Any(s => s.Id == filter.StandTypeId));
            }

            if (filter.excludeSpareParts)
            {
                Query.Where(p => p.PartTypeId != (int)PartTypeEnum.SparePart);
            }

        }

    }
}
