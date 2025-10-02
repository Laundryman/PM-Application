using PMApplication.Dtos.PlanModels;
using PMApplication.Entities;
using PMApplication.Entities.PartAggregate;
using PMApplication.Entities.StandAggregate;

namespace PMApplication.Interfaces
{
    public interface IScratchPadRepository : IAsyncRepositoryLong<ScratchPad>
    {
    }
}
