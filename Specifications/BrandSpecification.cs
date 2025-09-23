using Ardalis.Specification;
using PMApplication.Entities;
using PMApplication.Specifications.Filters;

namespace PMApplication.Specifications
{
    public class BrandSpecification : Specification<Brand>
    {
        public BrandSpecification(BrandFilter filter)
        {
            if (filter.Id != 0)
                Query.Where(x => x.Id == filter.Id);
            //if (filter.BrandId != 0)
            //    Query.Where(x => x.BrandId =  filter.BrandId);

            Query.OrderBy(x => x.Name);
        }

    }
}
