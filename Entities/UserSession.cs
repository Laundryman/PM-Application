using PMApplication.Interfaces;

namespace PMApplication.Entities;

public partial class UserSession: BaseEntity<Guid>, IAggregateRoot
{
    public Guid SessionGuid { get; set; }

    public string? UserName { get; set; }

    public int? ActiveOrderId { get; set; }

    public string? UserId { get; set; }

    public DateTime? DateCreated { get; set; }
}
