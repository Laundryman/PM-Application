using PMApplication.Entities.ClusterAggregate;
using PMApplication.Entities.JobsAggregate;
using PMApplication.Entities.OrderAggregate;
using PMApplication.Entities.PartAggregate;
using PMApplication.Entities.ProductAggregate;
using PMApplication.Interfaces;

namespace PMApplication.Entities;

public partial class Brand : BaseEntity<int>, IAggregateRoot
{
    public string Name { get; set; } = null!;

    public string? BrandLogo { get; set; }

    public bool ShelfLock { get; set; }

    public int? ThemeId { get; set; }

    public bool Disabled { get; set; }

    public bool BrandShop { get; set; }

    public decimal? AppVersion { get; set; }

    public virtual List<Cluster> Clusters { get; set; } = [];

    public virtual List<JobFolder> JobFolders { get; set; } = [];

    public virtual List<OrderWindow> OrderWindows { get; set; } = [];

    public virtual List<Part> Parts { get; set; } = [];

    public virtual List<Product> Products { get; set; } = [];
}
