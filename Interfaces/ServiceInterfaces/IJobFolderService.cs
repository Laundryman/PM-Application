using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMApplication.Entities.JobsAggregate;
using PMApplication.Specifications.Filters;

namespace PMApplication.Interfaces.ServiceInterfaces
{
    public interface IJobFolderService
    {
        Task<IReadOnlyList<JobFolder>> GetJobFolders(JobFolderFilter filter);
        Task<IReadOnlyList<JobFolderInfo>> GetJobFolderInfos(JobFolderFilter filter);
        Task<IReadOnlyList<JobFolderInfo>> GetFilteredJobFolders(int? page,
            int? pageSize,
            string sortBy,
            string sortOrder,
            string searchString,
            int? brandId);




        Task<JobFolder> GetJobFolder(int id);
        Task CreateJobFolder(JobFolder jobFolder);
        Task DeleteJobFolder(string id);
        Task SaveJobFolder();
    }

}
