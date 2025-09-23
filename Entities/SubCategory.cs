using PMApplication.Interfaces;

namespace PMApplication.Entities;

public partial class SubCategory : BaseEntity<int>, IAggregateRoot
{

    public string Name { get; set; } = null!;

    public int DisplayOrder { get; set; }
}
