using PMApplication.Entities.ClusterAggregate;
using PMApplication.Entities.JobsAggregate;
using PMApplication.Entities.OrderAggregate;
using PMApplication.Entities.PartAggregate;
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

    public virtual ICollection<Cluster> Clusters { get; set; } = new List<Cluster>();

    public virtual ICollection<JobFolder> JobFolders { get; set; } = new List<JobFolder>();

    public virtual ICollection<OrderWindow> OrderWindows { get; set; } = new List<OrderWindow>();

    public virtual ICollection<Part> Parts { get; set; } = new List<Part>();

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
