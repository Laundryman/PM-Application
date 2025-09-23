using PMApplication.Interfaces;

namespace PMApplication.Entities;

public partial class SystemAudit : BaseEntity<int>, IAggregateRoot
{
    public string TableName { get; set; } = null!;

    public string Action { get; set; } = null!;

    public string AuditData { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;
}
