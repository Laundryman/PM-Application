using Ardalis.Specification;
using PMApplication.Entities;
using PMApplication.Entities.OrderAggregate;
using PMApplication.Enums;
using PMApplication.Specifications.Filters;

namespace PMApplication.Specifications
{
    public class OrderWindowSpecification : Specification<OrderWindow>
    {
        public OrderWindowSpecification(OrderWindowFilter filter)
        {
            if (filter.BrandId != null)
                Query.Where(x => x.BrandId == filter.BrandId);
            if (filter.IncludeExpired == false)
            {
                Query.Where(x => x.EndDate > DateTime.UtcNow);
            }


            if (filter.GetFutureWindows)
            {
                Query.Where(x => x.StartDate > DateTime.UtcNow);
                Query.OrderBy(x => x.StartDate);
            }


            //Query.OrderBy(x => x.OrderCreated);
        }

    }
}
