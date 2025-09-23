using PMApplication.Interfaces;

namespace PMApplication.Entities;

public partial class HeroProduct : BaseEntity<int>, IAggregateRoot
{
    public int CategoryId { get; set; }

    public int BrandId { get; set; }

    public long ProductId { get; set; }

    public virtual Product Product { get; set; } = null!;
}
