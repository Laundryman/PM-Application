using PMApplication.Dtos.Filters;
using PMApplication.Dtos.PlanModels;
using PMApplication.Entities;
using PMApplication.Entities.PartAggregate;
using PMApplication.Entities.PlanogramAggregate;

namespace PMApplication.Interfaces.RepositoryInterfaces
{
    public interface IPartRepository : IAsyncRepositoryLong<Part>
    {
        Task<IReadOnlyList<PlanmMenuPart>?> GetPlanmMenu(int brandId, int countryId, int standTypeId);
        Task<IReadOnlyList<PlanmMenuPart>?> GetPlanmClusterMenu(int brandId, int clusterId, int standTypeId);
        Task<IReadOnlyList<Category>?> GetPlanmMenuCategories(int brandId, int countryId, int standTypeId);

        Task<IReadOnlyList<PartInfo>> GetFilteredParts(int brandId,
            int? partTypeId,
            int? parentCategoryId,
            int? categoryId,
            int? countryId, int? regionId, int? standTypeId, int? page,
            int? pageSize,
            string sortBy,
            string sortOrder,
            string searchString,
            bool shoppable);

        Task<IReadOnlyList<SearchPartInfo>> SearchParts(PartFilterDto filter);

    }


}
