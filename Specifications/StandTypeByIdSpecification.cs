using Ardalis.Specification;
using Microsoft.Graph.Models;
using PMApplication.Entities.CountriesAggregate;
using PMApplication.Entities.PartAggregate;
using PMApplication.Entities.StandAggregate;
using PMApplication.Specifications.Filters;

namespace PMApplication.Specifications
{
    public class StandTypeByIdSpecification : Specification<StandType>
    {
        public StandTypeByIdSpecification(StandTypeFilter filter)
        {
            //int brandId, int? regionId, int? countryId, int? categoryId, int? parentCategoryId, int? partId, bool shoppable

            if (filter.Id != null)
            {
                Query.Include(x => x.ParentStandType);
                Query.Where(x => x.Id == filter.Id);
                
            }


        }
    }
}
