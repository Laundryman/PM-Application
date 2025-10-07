using PMApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMApplication.Dtos;
using PMApplication.Specifications.Filters;

namespace PMApplication.Interfaces.ServiceInterfaces
{
    public interface ICategoryService
    {
        Task<IReadOnlyList<Category>> GetCategories(CategoryFilter filter);
        Task<IReadOnlyList<ShopCategory>> GetShopCategories(int BrandId, int CountryId);
        Task<Category> GetCategory(int id);
        Task CreateCategory(Category category);
        Task DeleteCategory(int id);
        void SaveCategory();
    }
}
