using Ardalis.Specification;
using LinqKit;
using PMApplication.Entities.ProductAggregate;
using PMApplication.Specifications.Filters;
using PMApplication.Entities.StandAggregate;

namespace PMApplication.Specifications
{
    public class StandByIdSpecification : Specification<Stand>
    {
        public StandByIdSpecification(long id)
        {
            Query.Where(p => p.Id == id)
                .Include(p => p.Countries)
                .Include(p => p.Regions)
                .Include(p => p.ColumnList)
                .Include(p => p.RowList);
        }

    }
}
