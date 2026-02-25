using PMApplication.Dtos.Filters;
using PMApplication.Entities;
using PMApplication.Entities.PartAggregate;
using PMApplication.Entities.PlanogramAggregate;
using PMApplication.Entities.ProductAggregate;

namespace PMApplication.Interfaces.RepositoryInterfaces
{
    public interface IProductRepository : IAsyncRepositoryLong<Product>
    {
        public Task<IReadOnlyList<SearchProductInfo>> SearchProducts(ProductFilterDto filter);
    }
}
