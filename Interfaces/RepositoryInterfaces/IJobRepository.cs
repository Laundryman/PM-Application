using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMApplication.Entities.JobsAggregate;
using PMApplication.Entities.StandAggregate;

namespace PMApplication.Interfaces.RepositoryInterfaces
{
    public interface IJobRepository : IAsyncRepository<Job>
    {
        Task<IReadOnlyList<JobInfo>> GetFilteredJobs(int? page, int? pageSize, string sortBy, string sortOrder, string searchString, int? brandId);

        Task<IReadOnlyList<JobInfo>> GetJobFolderJobs(int jobFolderId);
    }
}
