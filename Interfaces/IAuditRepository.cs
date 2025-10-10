using PMApplication.Dtos.PlanModels;
using PMApplication.Entities;
using PMApplication.Entities.PartAggregate;
using PMApplication.Entities.StandAggregate;

namespace PMApplication.Interfaces
{
    public interface IAuditRepository : IAsyncRepositoryLong<AuditLog>
    {
        Task<IReadOnlyList<AuditLog>?> GetReport(int? action, DateTime startDate, DateTime endDate, int? brandId, string userId, string role, int? page, int? pageSize, string sortOrder, string sortBy);

        Task<IReadOnlyList<AuditLog>?> GetActivityReport(string action, DateTime startDate, DateTime endDate,
            string brandIds, string userId, string roles, int? page, int? pageSize, string sortOrder, string sortBy);

        Task<IReadOnlyList<AuditLog>?> GetExportActivityReport(string action, DateTime startDate, DateTime endDate,
            string brandIds, string userId, string roles);
    }
}
