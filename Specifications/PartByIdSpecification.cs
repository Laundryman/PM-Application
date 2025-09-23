using Ardalis.Specification;
using PMApplication.Entities.PartAggregate;

namespace PMApplication.Specifications
{
    public class PartByIdSpecification : Specification<Part>
    {
        public PartByIdSpecification(int Id)
        {
            Query.Where(x => x.Id == Id);
        }

    }
}
