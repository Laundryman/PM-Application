using Ardalis.Specification;
using LinqKit;
using PMApplication.Entities.ProductAggregate;
using PMApplication.Specifications.Filters;

namespace PMApplication.Specifications
{
    public class ProductByIdSpecification : Specification<Product>
    {
        public ProductByIdSpecification(long id)
        {
            Query.Where(p => p.Id == id)
                .Include(p => p.Countries)
                .Include(p => p.Regions)
                .Include(p => p.Shades);
        }

    }
}
