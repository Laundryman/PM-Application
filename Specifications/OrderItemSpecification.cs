using Ardalis.Specification;
using LinqKit;
using PMApplication.Entities.CountriesAggregate;
using PMApplication.Entities.OrderAggregate;
using PMApplication.Specifications.Filters;

namespace PMApplication.Specifications
{
    public class OrderItemSpecification : Specification<OrderItem>
    {
        public OrderItemSpecification(OrderItemFilter filter)
        {
            Query.OrderBy(x => x.DateAdded);

            if (filter.OrderId != null)
            {
                Query.Where(x => x.OrderId == filter.OrderId);
            }

            if (filter.IsPagingEnabled)
                Query.Skip(PaginationHelper.CalculateSkip(filter))
                    .Take(PaginationHelper.CalculateTake(filter));


        }

    }
}
