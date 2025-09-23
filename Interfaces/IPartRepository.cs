using PMApplication.Dtos.PlanModels;
using PMApplication.Entities.PartAggregate;

namespace PMApplication.Interfaces
{
    public interface IPartRepository : IAsyncRepositoryLong<Part>
    {
        Task<IReadOnlyList<MenuPartDto>?> GetPlanxMenu(int brandId, int countryId, int standTypeId);
    }
}
