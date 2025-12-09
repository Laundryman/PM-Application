using Ardalis.GuardClauses;
using AutoMapper;
using Microsoft.Extensions.Logging;
using Microsoft.Graph.Models;
using PMApplication.Entities.CountriesAggregate;
using PMApplication.Entities.PartAggregate;
using PMApplication.Entities.ProductAggregate;
using PMApplication.Interfaces;
using PMApplication.Interfaces.RepositoryInterfaces;
using PMApplication.Interfaces.ServiceInterfaces;
using PMApplication.Specifications;
using PMApplication.Specifications.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMApplication.Services
{
    public class ProductService: IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IShadeRepository _shadeRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<ProductService> _logger;

        public ProductService(IProductRepository productRepository, IShadeRepository shadeRepository)
        {
            _productRepository = productRepository;
            _shadeRepository = shadeRepository;
        }

        #region IProductService Members

        public async Task<IReadOnlyList<Product>> GetProducts(ProductFilter filter)
        {
            var spec = new ProductSpecification(filter);
            var products = _productRepository.ListAllAsync();
            return await products;
        }

        public Task<IReadOnlyList<Product>> GetProductsByBrand(int brandId)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Product>> GetProductsByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Product>> GetProductsByCategory(int brandId, int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Product>> GetProductsByCountryByCategory(int brandId, int categoryId, IEnumerable<Country> countries)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Product>> GetProductsByParentCategory(int brandId, int categoryId, IEnumerable<Country> countries)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> GetProduct(long id)
        {
            try
            {
                var product = await _productRepository.GetByIdAsync(id);
                return product;
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, "Error retrieving product with id {@Id}", id);
                throw;
            }
        }

        public Task<HeroProduct> GetHeroProduct(int categoryId, int brandId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Part> GetFactices(long productId)
        {
            throw new NotImplementedException();
        }

        public void SetHeroProduct(int productId, int categoryId, int brandId)
        {
            throw new NotImplementedException();
        }

        public async Task<IReadOnlyList<Shade>> GetShades(ShadeFilter filter)
        {
            try
            {
                var spec = new ShadeSpecification(filter);
                var shades = await _shadeRepository.ListAsync(spec);
                return shades;
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, "Error retrieving shades with filter {@Filter}", filter);
                throw;
            }
        }

        public async Task<IReadOnlyList<Shade>> GetShades(long shadeId)
        {
            var shades = _shadeRepository.ListAllAsync();
            return await shades;
        }
        public async Task<Shade> GetShade(long id)
        {
            try
            {
                var shade = await _shadeRepository.GetByIdAsync(id);
                return shade;
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, "Error retrieving shade with id {@Id}", id);
                throw;

            }

        }

        public void CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public void ReloadProduct(int id)
        {
            throw new NotImplementedException();
        }

        public void CreateShade(Shade shade)
        {
            throw new NotImplementedException();
        }

        public void SaveShade()
        {
            throw new NotImplementedException();
        }

        public void DeleteShade(int id)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
