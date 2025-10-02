using PMApplication.Dtos.PlanModels;
using PMApplication.Entities.PartAggregate;
using PMApplication.Entities.PlanogramAggregate;

namespace PMApplication.Interfaces
{
    public interface IPlanogramRepository : IAsyncRepositoryLong<Planogram>
    {
        Task<IReadOnlyList<Sku>> GetSkuList(long id, string userId, bool hasColumns);
    }
}
