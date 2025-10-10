using PMApplication.Dtos.PlanModels;
using PMApplication.Entities.PartAggregate;
using PMApplication.Entities.PlanogramAggregate;

namespace PMApplication.Interfaces.RepositoryInterfaces
{
    public interface IPlanogramRepository : IAsyncRepositoryLong<Planogram>
    {
        Task<IReadOnlyList<Sku>> GetSkuList(long id, string userId, bool hasColumns);

        Task<IReadOnlyList<PlanogramInfo>> GetPlanogramInfo(int statusId, int brandId, int? jobId, int? regionId,
            int? countryId, int? standTypeId);
    }
}
