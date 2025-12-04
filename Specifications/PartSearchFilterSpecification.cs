using Ardalis.Specification;
using PMApplication.Entities.PartAggregate;

namespace PMApplication.Specifications
{
    public class PartSearchFilterSpecification : Specification<Part>
    {
        public PartSearchFilterSpecification(string partNumber, int? partTypeId, int? categoryId, int? parentCategoryId, int? brandId)
        {
            Query.Where(i => (!brandId.HasValue || i.BrandId == brandId));

        }
    }
}
