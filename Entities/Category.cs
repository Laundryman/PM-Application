using System.ComponentModel.DataAnnotations.Schema;
using PMApplication.Entities.PartAggregate;
using PMApplication.Entities.ProductAggregate;
using PMApplication.Interfaces;

namespace PMApplication.Entities;

public partial class Category : BaseEntity<int>, IAggregateRoot
{
    public string Name { get; set; } = null!;

    public int DisplayOrder { get; set; }
    [ForeignKey("ParentCategory")]
    public int? ParentCategoryId { get; set; }
    public string? ParentCategoryName { get; set; }

    public int? HeroProductId { get; set; }
    public Category ParentCategory { get; set; } = null!;

    [InverseProperty("ParentCategory")]
    public virtual ICollection<Category> SubCategories { get; set; } = new List<Category>();
    public virtual ICollection<Part> Parts { get; set; } = new List<Part>();

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
