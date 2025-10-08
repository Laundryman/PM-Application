using PMApplication.Dtos.PlanModels;
using PMApplication.Entities.PartAggregate;
using PMApplication.Entities.StandAggregate;

namespace PMApplication.Interfaces.RepositoryInterfaces
{
    public interface IStandRepository : IAsyncRepository<Stand>
    {
        Task<Stand> GetStand(int Id, bool includeColumnUprights);
    }
}
