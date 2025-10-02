using PMApplication.Dtos.PlanModels;
using PMApplication.Entities.PartAggregate;
using PMApplication.Entities.PlanogramAggregate;

namespace PMApplication.Interfaces
{
    public interface IPlanogramNoteRepository : IAsyncRepositoryLong<PlanogramNote>
    {

    }
}
