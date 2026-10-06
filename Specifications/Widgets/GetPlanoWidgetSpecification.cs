using Ardalis.Specification;
using LinqKit;
using PMApplication.Entities;
using PMApplication.Entities.PlanogramAggregate;
using PMApplication.Entities.ProductAggregate;
using PMApplication.Dtos.Filters.Widgets;

namespace PMApplication.Specifications.Widgets
{
    public class GetPlanoWidgetSpecification : Specification<Planogram>
    {
        public GetPlanoWidgetSpecification(PlanoWidgetFilterDto filter)
        {
            if (filter.BrandId != 0 && filter.BrandId != null)
                Query.Where(x => x.BrandId == filter.BrandId);
            if (!String.IsNullOrEmpty(filter.UserId))
                Query.Where(x => x.LastUpdatedBy == filter.UserId);
            if (!filter.Archived)
                Query.Where(x => x.StatusId != 7);
            if (!filter.IncludeDeleted)
            {
                Query.Where(x => x.StatusId != 4);
            }
            //if (filter.LoadRelatedEntities == true)
            //{
            //    Query.Include(x => x.Stand)
            //        .ThenInclude(x => x.ColumnList)
            //         .Include(x => x.Job)
            //         .Include(x => x.ScratchPad)
            //         .Include(x => x.PlanogramNotes)
            //         .Include(x => x.Stand);

            //}

            if (filter.CountriesList != null)
            {
                var requiredCountries = filter.CountriesList.Split(",").ToList();
                var predicate = PredicateBuilder.New<Planogram>(false);
                foreach (var country in requiredCountries)
                {
                    predicate = predicate.Or(x => x.CountryId != null && x.CountryId == int.Parse(country));
                }
                Query.Where(predicate);

            }

            Query.OrderByDescending(x => x.DateUpdated).Take(20)
                .Include(x => x.Brand);

        }

    }
}
