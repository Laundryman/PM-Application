using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMApplication.Entities.JobsAggregate;
using PMApplication.Specifications.Filters;

namespace PMApplication.Interfaces.ServiceInterfaces
{
    public interface IJobService
    {
        Task<IReadOnlyList<Job>> GetJobs(JobFilter filter);

        Task<IReadOnlyList<JobInfo>> GetFilteredJobs(int? page,
            int? pageSize,
            string sortBy,
            string sortOrder,
            string searchString,
            int? brandId);

        Task<IReadOnlyList<JobInfo>> GetJobFolderJobs(int jobFolderId);
        Task<Job> GetJob(int id);
        Task CreateJob(Job job);
        Task DeleteJob(int id);
        Task SaveJob();
    }
}
