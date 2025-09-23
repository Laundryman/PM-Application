using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMApplication.Entities;
using PMApplication.Interfaces;

namespace PMApplication.Services
{
    public interface ILmAuditService
    {
        List<LMAuditLog> GetReport(int? action, DateTime startDate, DateTime endDate, int? brandId, string userId, string role, int? page, int? pageSize, string sortOrder, string sortBy);
        List<LMAuditLog> GetActivityReport(string action, DateTime startDate, DateTime endDate, string brandIds, string userId, string roles, int? page, int? pageSize, string sortOrder, string sortBy);
        List<LMAuditLog> GetExportActivityReport(string action, DateTime startDate, DateTime endDate, string brandIds, string userId, string roles);
        void AuditEvent(LMAuditLog action);
    }

    public class LmAuditService : ILmAuditService
    {
        private readonly ILMAuditRepository _lmAuditRepository;
        //private readonly IUnitOfWork _unitOfWork;

        public LmAuditService(ILMAuditRepository lmAuditRepository)
        {
            _lmAuditRepository = lmAuditRepository;
            //_unitOfWork = unitOfWork;
        }

        public void AuditEvent(LMAuditLog action)
        {
            _lmAuditRepository.AddAsync(action);

        }

        List<LMAuditLog> ILmAuditService.GetActivityReport(string action, DateTime startDate, DateTime endDate, string brandIds, string userId,
            string roles, int? page, int? pageSize, string sortOrder, string sortBy)
        {
            var report = _lmAuditRepository.GetActivityReport(action, startDate, endDate, brandIds, userId, roles, page, pageSize,
                sortOrder, sortBy); throw new NotImplementedException();
        }

        List<LMAuditLog> ILmAuditService.GetExportActivityReport(string action, DateTime startDate, DateTime endDate, string brandIds, string userId,
            string roles)
        {
            var report = _lmAuditRepository.GetExportActivityReport(action, startDate, endDate, brandIds, userId, roles);

            throw new NotImplementedException();
        }

        List<LMAuditLog> ILmAuditService.GetReport(int? action, DateTime startDate, DateTime endDate, int? brandId, string userId, string role, int? page,
            int? pageSize, string sortOrder, string sortBy)
        {
            var report = _lmAuditRepository.GetReport(action, startDate, endDate, brandId, userId, role, page, pageSize,
                sortOrder, sortBy);
            throw new NotImplementedException();
        }


    }

}
