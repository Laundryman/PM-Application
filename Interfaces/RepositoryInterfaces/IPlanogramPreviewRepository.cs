using PMApplication.Dtos;
using PMApplication.Dtos.Filters;
using PMApplication.Entities;
using PMApplication.Entities.OrderAggregate;
using PMApplication.Entities.PlanogramAggregate;
using PMApplication.Specifications.Filters;

namespace PMApplication.Interfaces.RepositoryInterfaces
{
    public interface IPlanogramPreviewRepository : IAsyncRepositoryLong<PlanogramPreview>
    {
        Task<PlanogramPreview> GetPreview(PlanogramFilter filter);

    }
}
