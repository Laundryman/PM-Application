using Ardalis.Specification;
using LinqKit;
using Microsoft.Graph.Models;
using PMApplication.Entities.CountriesAggregate;
using PMApplication.Entities.PartAggregate;
using PMApplication.Entities.StandAggregate;
using PMApplication.Specifications.Filters;

namespace PMApplication.Specifications
{
    public class EditStandSpecification : Specification<Stand>
    {
        public EditStandSpecification(StandFilter filter)
        {

            if (filter.Id != 0 && filter.Id != null)
            {
                Query.Where(x => x.Id == filter.Id)
                    .Include(x => x.Regions)
                    .Include(x => x.Countries)
                    .Include(x => x.ColumnList)
                    .Include(x => x.RowList);
            }
        }
    }
}
