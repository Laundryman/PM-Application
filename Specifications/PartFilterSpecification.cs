using Ardalis.Specification;
using PMApplication.Entities.PartAggregate;

namespace PMApplication.Specifications
{
    public class PartFilterSpecification : Specification<Part>
    {
        public PartFilterSpecification(string partNumber, int? partTypeId, int? categoryId, int? parentCategoryId, int? brandId)
        {
            Query.Where(i => (!brandId.HasValue || i.BrandId == brandId) &&
                (!partTypeId.HasValue || i.PartTypeId == partTypeId) &&
                (!categoryId.HasValue || i.CategoryId == categoryId) &&
                (!(partNumber == "") || i.PartNumber == partNumber) &&
                (!partTypeId.HasValue || i.Category.ParentCategoryId == parentCategoryId));
        }
    }
}
