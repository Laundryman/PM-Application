using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.GuardClauses;
using Microsoft.Extensions.Logging;
using PMApplication.Entities;
using PMApplication.Entities.PartAggregate;
using PMApplication.Interfaces;
using PMApplication.Interfaces.ServiceInterfaces;
using PMApplication.Specifications;
using PMApplication.Specifications.Filters;
using AutoMapper;
using PMApplication.Entities.CountriesAggregate;
using PMApplication.Interfaces.RepositoryInterfaces;

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

        public async Task<IReadOnlyList<Product>> GetProducts()
        {
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

        Task<Product> IProductService.GetProduct(long id)
        {
            throw new NotImplementedException();
        }

        Task<HeroProduct> IProductService.GetHeroProduct(int categoryId, int brandId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Part> GetFactices(long productId)
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(long id)
        {
            throw new NotImplementedException();
        }

        public HeroProduct GetHeroProduct(int categoryId, int brandId)
        {
            throw new NotImplementedException();
        }

        public void SetHeroProduct(int productId, int categoryId, int brandId)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Shade>> GetShades()
        {
            throw new NotImplementedException();
        }

        public async Task<IReadOnlyList<Shade>> GetShades(long shadeId)
        {
            var shades = _shadeRepository.ListAllAsync();
            return await shades;
        }
        public Task<Shade> GetShade(long id)
        {
            throw new NotImplementedException();
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
