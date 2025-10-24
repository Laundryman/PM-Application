using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMApplication.Entities;
using PMApplication.Interfaces;
using PMApplication.Interfaces.ServiceInterfaces;

namespace PMApplication.Services
{


    public class AuditService : IAuditService
    {
        private readonly IAuditRepository _auditRepository;
        //private readonly IUnitOfWork _unitOfWork;

        public AuditService(IAuditRepository auditRepository)
        {
            _auditRepository = auditRepository;
            //_unitOfWork = unitOfWork;
        }

        public async Task<AuditLog> AuditEvent(AuditLog action)
        {
            return await _auditRepository.AddAsync(action);

        }

        List<AuditLog> IAuditService.GetActivityReport(string action, DateTime startDate, DateTime endDate, string brandIds, string userId,
            string roles, int? page, int? pageSize, string sortOrder, string sortBy)
        {
            var report = _auditRepository.GetActivityReport(action, startDate, endDate, brandIds, userId, roles, page, pageSize,
                sortOrder, sortBy); throw new NotImplementedException();
        }

        List<AuditLog> IAuditService.GetExportActivityReport(string action, DateTime startDate, DateTime endDate, string brandIds, string userId,
            string roles)
        {
            var report = _auditRepository.GetExportActivityReport(action, startDate, endDate, brandIds, userId, roles);

            throw new NotImplementedException();
        }

        List<AuditLog> IAuditService.GetReport(int? action, DateTime startDate, DateTime endDate, int? brandId, string userId, string role, int? page,
            int? pageSize, string sortOrder, string sortBy)
        {
            var report = _auditRepository.GetReport(action, startDate, endDate, brandId, userId, role, page, pageSize,
                sortOrder, sortBy);
            throw new NotImplementedException();
        }


    }

}
