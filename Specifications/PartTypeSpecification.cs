using Ardalis.Specification;
using PMApplication.Entities.PartAggregate;

namespace PMApplication.Specifications
{
    public class PartTypeSpecification : Specification<PartType>
    {
        public PartTypeSpecification()
        {
            Query.OrderBy(x => x.Name);
        }

    }
}
