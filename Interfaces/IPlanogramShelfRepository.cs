using PMApplication.Dtos.PlanModels;
using PMApplication.Entities.PartAggregate;
using PMApplication.Entities.PlanogramAggregate;

namespace PMApplication.Interfaces
{
    public interface IPlanogramShelfRepository : IAsyncRepositoryLong<PlanogramShelf>
    {
        //Task<IReadOnlyList<MenuPartDto>?> GetPlanxMenu(int brandId, int countryId, int standTypeId);
    }
}
