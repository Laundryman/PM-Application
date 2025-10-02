using Ardalis.Specification;
using PMApplication.Entities;
using PMApplication.Entities.OrderAggregate;
using PMApplication.Enums;
using PMApplication.Specifications.Filters;

namespace PMApplication.Specifications
{
    public class OrderSpecification : Specification<Order>
    {
        public OrderSpecification(OrderFilter filter)
        {
            if (filter.CountryId != null)
                Query.Where(x => x.CountryId == filter.CountryId);
            if (filter.OrderStatus != null)
                Query.Where(x => x.OrderStatus == filter.OrderStatus);

            Query.OrderBy(x => x.OrderCreated);
        }

    }
}
