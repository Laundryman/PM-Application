using Ardalis.Specification;
using LinqKit;
using Microsoft.Graph.Models;
using PMApplication.Entities.CountriesAggregate;
using PMApplication.Entities.PartAggregate;
using PMApplication.Entities.StandAggregate;
using PMApplication.Specifications.Filters;

namespace PMApplication.Specifications
{
    public class StandSpecification : Specification<Stand>
    {
        public StandSpecification(StandFilter filter)
        {
            Query.OrderBy(x => x.Name)
                .ThenByDescending(x => x.StandTypeId);

            if (filter.Id != 0 && filter.Id != null)
            {
                Query.Where(x => x.Id == filter.Id)
                    .Include(x => x.StandType)
                    .ThenInclude(st => st.ParentStandType)
                    .Include(x => x.ColumnList)
                    .ThenInclude(x => x.StandColumnUprights)
                    .Include(x => x.RowList);
            }

            if (filter.BrandId != 0 && filter.BrandId != null)
                Query.Where(x => x.BrandId == filter.BrandId);

            if ((filter.ParentStandTypeId != 0) && filter.ParentStandTypeId != null)
                Query.Where(x => x.ParentStandTypeId == filter.ParentStandTypeId);

            if ((filter.StandTypeId != 0) && filter.StandTypeId != null)
                Query.Where(x => x.StandTypeId == filter.StandTypeId);

            if ((filter.Discontinued ))
                Query.Include(x => x.Discontinued == filter.Discontinued);

            if ((filter.CountryId != 0) && filter.CountryId != null)
            {
                Query.Include(x => x.Countries
                        .Where(x => x.Id == filter.CountryId));

            }


            if (!string.IsNullOrEmpty(filter.RegionIds) && string.IsNullOrEmpty(filter.CountryIds))
            {
                var requiredRegions = filter.RegionIds.Split(",").ToList();
                var predicate = PredicateBuilder.New<Stand>(false);
                foreach (var region in requiredRegions)
                {
                    var regionId = int.Parse(region);
                    predicate = predicate.Or(x => x.RegionsList != null && x.RegionsList.Contains(region));
                }
                Query.Where(predicate);

            }

            if (!string.IsNullOrEmpty(filter.CountryIds))
            {
                var requiredCountries = filter.CountryIds.Split(",").ToList();
                var predicate = PredicateBuilder.New<Stand>(false);
                foreach (var country in requiredCountries)
                {
                    predicate = predicate.Or(x => x.CountriesList != null && x.CountriesList.Contains(country));
                }
                Query.Where(predicate);

            }
        }
    }
}
