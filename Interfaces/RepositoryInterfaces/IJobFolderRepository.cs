using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMApplication.Entities.JobsAggregate;
using PMApplication.Entities.StandAggregate;
using PMApplication.Specifications.Filters;

namespace PMApplication.Interfaces.RepositoryInterfaces
{
    public interface IJobFolderRepository : IAsyncRepository<JobFolder>
    {
        //Task<IReadOnlyList<JobFolderInfo>> GetJobFolders(JobFolderFilter filter);

        Task<IReadOnlyList<JobFolderInfo>> GetFilteredJobFolders(
            int? page,
            int? pageSize,
            string sortBy,
            string sortOrder,
            string searchString,
            int? brandId);

        Task<IReadOnlyList<JobFolderInfo>> GetJobFolderInfos(JobFolderFilter filter);
    }
}
