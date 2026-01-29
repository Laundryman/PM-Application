using PMApplication.Interfaces;

namespace PMApplication.Entities;

public partial class Role: BaseEntity<int>, IAggregateRoot
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;
}
