using PMApplication.Dtos.Filters;
using PMApplication.Dtos.PlanModels;
using PMApplication.Entities.ClusterAggregate;
using PMApplication.Entities.PartAggregate;
using PMApplication.Entities.PlanogramAggregate;
using PMApplication.Entities.StandAggregate;

namespace PMApplication.Interfaces.RepositoryInterfaces
{
    public interface IClusterRepository : IAsyncRepositoryLong<Cluster>
    {
        Task<IReadOnlyList<SearchClusterInfo>> SearchClusters(ClusterFilterDto filter);
    }
}
