using PMApplication.Entities.CountriesAggregate;
using PMApplication.Entities.PartAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMApplication.Specifications.Filters;
using PMApplication.Entities.ProductAggregate;

namespace PMApplication.Interfaces.ServiceInterfaces
{
    public interface IProductService
    {
        Task<IReadOnlyList<Product>> GetProducts(ProductFilter filter);
        Task<IReadOnlyList<Product>> GetProductsByBrand(int brandId);
        Task<IReadOnlyList<Product>> GetProductsByCategory(int categoryId);
        Task<IReadOnlyList<Product>> GetProductsByCategory(int brandId, int categoryId);
        Task<IReadOnlyList<Product>> GetProductsByCountryByCategory(int brandId, int categoryId, IEnumerable<Country> countries);
        Task<IReadOnlyList<Product>> GetProductsByParentCategory(int brandId, int categoryId, IEnumerable<Country> countries);
        Task<Product> GetProduct(long id);
        Task<HeroProduct> GetHeroProduct(int categoryId, int brandId);
        void SetHeroProduct(int productId, int categoryId, int brandId);

        Task<IReadOnlyList<Shade>> GetShades(ShadeFilter filter);
        Task<Shade> GetShade(long id);
        void CreateProduct(Product product);
        void DeleteProduct(int id);
        void ReloadProduct(int id);

        void CreateShade(Shade shade);
        void SaveShade();
        void DeleteShade(int id);
    }
}
