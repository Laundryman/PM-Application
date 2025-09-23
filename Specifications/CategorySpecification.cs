using Ardalis.Specification;
using PMApplication.Entities;
using PMApplication.Specifications.Filters;

namespace PMApplication.Specifications
{
    public class CategorySpecification : Specification<Category>
    {
        public CategorySpecification(CategoryFilter filter)
        {
            if (filter.ParentCatId != 0)
                Query.Where(x => x.ParentCategoryId == filter.ParentCatId);
            if (filter.GetParents)
                Query.Where(x => x.ParentCategoryId == 0);
            if (filter.Id != 0)
                Query.Where(x => x.Id == filter.Id);
            //if (filter.BrandId != 0)
            //    Query.Where(x => x.BrandId =  filter.BrandId);

            Query.OrderBy(x => x.Name);
        }

    }
}
