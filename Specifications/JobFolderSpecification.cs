using Ardalis.Specification;
using PMApplication.Entities;
using PMApplication.Entities.JobsAggregate;
using PMApplication.Specifications.Filters;

namespace PMApplication.Specifications
{
    public class JobFolderSpecification : Specification<JobFolder>
    {
        public JobFolderSpecification(JobFolderFilter filter)
        {
            if (filter.BrandId != 0)
                Query.Where(x => x.BrandId == filter.BrandId);
            if (filter.JobFolderId != 0)
                Query.Where(x => x.Id != filter.JobFolderId);
            if (filter.HasJobs)
                Query.Include(f => f.Jobs)
                .Where(x => x.Jobs.Count > 0);
            Query.OrderBy(x => x.Name);
        }

    }
}
