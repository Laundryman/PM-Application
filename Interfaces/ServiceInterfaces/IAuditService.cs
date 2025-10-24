using PMApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMApplication.Interfaces.ServiceInterfaces
{
    public interface IAuditService
    {
        List<AuditLog> GetReport(int? action, DateTime startDate, DateTime endDate, int? brandId, string userId, string role, int? page, int? pageSize, string sortOrder, string sortBy);
        List<AuditLog> GetActivityReport(string action, DateTime startDate, DateTime endDate, string brandIds, string userId, string roles, int? page, int? pageSize, string sortOrder, string sortBy);
        List<AuditLog> GetExportActivityReport(string action, DateTime startDate, DateTime endDate, string brandIds, string userId, string roles);
        Task<AuditLog> AuditEvent(AuditLog action);
    }
}
