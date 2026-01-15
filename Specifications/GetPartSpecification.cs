using Ardalis.Specification;
using PMApplication.Entities.PartAggregate;
using PMApplication.Enums;
using PMApplication.Specifications.Filters;

namespace PMApplication.Specifications
{
    public class GetPartSpecification : Specification<Part>
    {
        public GetPartSpecification(PartFilter filter)
        {
            Query.OrderBy(x => x.Name)
                    .ThenByDescending(x => x.PartNumber);

            if (filter.Id != null)
            {
                Query.Include(p => p.Products)
                    .ThenInclude(p => p.Product)
                    .ThenInclude(p => p.Shades)
                    .Include(p => p.Countries)
                    .Include(p => p.StandTypes)
                    .ThenInclude(s => s.StandType);
                Query.Where(p => p.Id == filter.Id);
            }


        }

    }
}
