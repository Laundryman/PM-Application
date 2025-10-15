using Ardalis.Specification;
using PMApplication.Entities;
using PMApplication.Entities.JobsAggregate;
using PMApplication.Specifications.Filters;

namespace PMApplication.Specifications
{
    public class JobSpecification : Specification<Job>
    {
        public JobSpecification(JobFilter filter)
        {
            if (filter.BrandId != 0)
                Query.Where(x => x.Id == filter.BrandId);
            //if (filter.BrandId != 0)
            //    Query.Where(x => x.BrandId =  filter.BrandId);

            Query.OrderBy(x => x.Name);
        }

    }
}
