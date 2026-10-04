using Ardalis.Specification;
using LinqKit;
using PMApplication.Entities;
using PMApplication.Entities.CountriesAggregate;
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

            if (filter.RegionList != null)
            {
                var requiredRegions = filter.RegionList.Split(",").ToList();
                var predicate = PredicateBuilder.New<JobFolder>(false);
                foreach (var region in requiredRegions)
                {
                    var regionId = int.Parse(region);
                    predicate = predicate.Or(x => x.RegionId == regionId);
                }
                Query.Where(predicate);

            }

            if (filter.RegionId!= null && filter.RegionId != 0)
            {
                Query.Where(j => j.RegionId == filter.RegionId);
            }

            if (filter.CountryId != null && filter.CountryId != 0)
            {
                Query.Where(j => j.Countries.Any(c => c.Id == filter.CountryId));
            }

            //if (filter.CountryList != null)
            //{
            //    var requiredCountries = filter.CountryList.Split(",").ToList();
            //    var predicate = PredicateBuilder.New<JobFolder>(false);
            //    foreach (var country in requiredCountries)
            //    {
            //        var countryId = int.Parse(country);
            //        predicate = predicate.Or(x => x.Countries.Any(c => c.Id == countryId));
            //    }
            //    Query.Where(predicate);

            //}
            if (filter.IncludeChildren)
            {
                Query.Include(x => x.Jobs!)
                .ThenInclude(j => j.Planograms)
                .Include(x => x.Region)
                .Include(x => x.Countries);
            }

            if (filter.Id != 0)
                Query.Where(x => x.Id != filter.Id);
            if (filter.HasJobs == true)
                Query.Include(f => f.Jobs)
                .Where(x => x.Jobs!.Count > 0);
            Query.OrderBy(x => x.Name);
        }

    }
}
