using Ardalis.Specification;
using LinqKit;
using PMApplication.Entities;
using PMApplication.Specifications.Filters;

namespace PMApplication.Specifications
{
    public class ProductSpecification : Specification<Product>
    {
        public ProductSpecification(ProductFilter filter)
        {
            Query.Where(x => x.Published == true);

            //if (filter.CountryList != null)
            //{
            //    Query.Where(x.CountryList )
            //}
            if (filter.PartId != null)
                Query.Where(x => x.Parts.All(p => p.PartId == filter.PartId));

            if ((filter.BrandId != null))
                Query.Where(x => x.BrandId == filter.BrandId);

            if (filter.CategoryId != null)
            {
                Query.Where(x => x.CategoryId == filter.CategoryId);
            }

            if (filter.ParentCategoryId != null)
            {
                Query.Where(x => x.ParentCategoryId == filter.ParentCategoryId);
            }


            if (filter.CountryList != null)
            {
                var requiredCountries = filter.CountryList.Split(",").ToList();
                var predicate = PredicateBuilder.New<Product>(false);
                foreach (var country in requiredCountries)
                {
                    predicate = predicate.Or(x => x.CountryList.Contains(country));
                }
                Query.Where(predicate);

            }

            if (filter.IsPublished)
            {
                Query.Where(x => x.Published == true);
            }

            Query.OrderBy(x => x.Name);

            var baseFilter = new BaseFilter();

            if (filter.IsPagingEnabled)
                Query.Skip(PaginationHelper.CalculateSkip(filter))
                    .Take(PaginationHelper.CalculateTake(filter));


        }

    }
}
