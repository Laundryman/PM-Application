using PMApplication.Dtos.PlanModels;
using PMApplication.Entities.ClusterAggregate;
using PMApplication.Entities.PartAggregate;
using PMApplication.Entities.PlanogramAggregate;

namespace PMApplication.Interfaces.RepositoryInterfaces
{
    public interface IClusterRepository : IAsyncRepositoryLong<Cluster>
    {
    }
}
