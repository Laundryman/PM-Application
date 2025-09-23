using PMApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMApplication.Dtos;

namespace PMApplication.Interfaces.ServiceInterfaces
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetCategories();
        IEnumerable<Category> GetParentCategories();
        IEnumerable<Category> GetSubCategories(int ParentCategoryId);
        IEnumerable<ShopCategory> GetShopCategories(int brandId, int countryId);
        Category GetCategory(int id);
        void CreateCategory(Category category);
        void DeleteCategory(int id);
        void SaveCategory();
    }
}
