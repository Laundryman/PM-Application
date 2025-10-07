using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Logging;
using PMApplication.Dtos;
using PMApplication.Entities;
using PMApplication.Interfaces;
using PMApplication.Interfaces.ServiceInterfaces;
using PMApplication.Specifications.Filters;

namespace PMApplication.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IAsyncRepository<Category> _categoryRepositorySync;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<PartService> _logger;

        public CategoryService(IAsyncRepository<Category> categoryRepositorySync, ICategoryRepository categoryRepository, IMapper mapper, ILogger<PartService> logger)
        {
            _categoryRepository = categoryRepository;
            _categoryRepositorySync = categoryRepositorySync;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<IReadOnlyList<Category>> GetCategories(CategoryFilter filter)
        {
            var spec = new Specifications.CategorySpecification(filter);
            return await _categoryRepositorySync.ListAsync(spec);
        }

        public async Task<IReadOnlyList<ShopCategory>> GetShopCategories(int BrandId, int CountryId)
        {
            return await _categoryRepository.GetShopCategories(BrandId, CountryId);
        }

        public async Task<Category> GetCategory(int id)
        {
            return await _categoryRepository.GetByIdAsync(id);
        }

        public async Task CreateCategory(Category category)
        {
            await _categoryRepository.AddAsync(category);
        }

        public async Task DeleteCategory(int id)
        {
            var category = await _categoryRepository.GetByIdAsync(id);
            await _categoryRepository.DeleteAsync(category);
        }

        public void SaveCategory()
        {
            throw new NotImplementedException();
        }
    }
}
