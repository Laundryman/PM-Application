using PMApplication.Entities.PartAggregate;
using PMApplication.Entities.PlanogramAggregate;

namespace PMApplication.Interfaces.RepositoryInterfaces
{
    public interface IPartRepository : IAsyncRepositoryLong<Part>
    {
        Task<IReadOnlyList<PlanmMenuPart>?> GetPlanxMenu(int brandId, int countryId, int standTypeId);

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
    }
}
