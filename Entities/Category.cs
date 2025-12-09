using PMApplication.Entities.PartAggregate;
using PMApplication.Entities.ProductAggregate;
using PMApplication.Interfaces;

namespace PMApplication.Entities;

public partial class Category : BaseEntity<int>, IAggregateRoot
{
    public string Name { get; set; } = null!;

    public int DisplayOrder { get; set; }

    public int? ParentCategoryId { get; set; }

    public int? HeroProductId { get; set; }

    public virtual ICollection<Part> Parts { get; set; } = new List<Part>();

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
