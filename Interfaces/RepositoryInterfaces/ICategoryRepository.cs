using PMApplication.Dtos;
using PMApplication.Entities;

namespace PMApplication.Interfaces.RepositoryInterfaces
{
    public interface ICategoryRepository : IAsyncRepository<Category>
    {
        Task<IReadOnlyList<ShopCategory>> GetShopCategories(int brandId, int countryId);

    }
}
