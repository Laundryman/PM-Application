using PMApplication.Interfaces;

namespace PMApplication.Entities;

public enum LogActionEnum : int
{
    Login = 1,
    Logout = 2,
    SessionEnd = 3,
    Activate = 4,
    CreatePlano = 5,
    SubmitPlano = 6,
    ApprovePlano = 7,
    EditPlano = 8,
    CreateOrder = 9,
    EditOrder = 10,
    SubmitOrder = 11,
    ApproveOrder = 12

}

public partial class AuditLog : BaseEntity<long>, IAggregateRoot
{

    public DateTime Date { get; set; }

    public string Message { get; set; } = null!;

    public int? LegacyUserId { get; set; }

    public int? BrandId { get; set; }

    public string? UserName { get; set; }

    public int? Action { get; set; }

    public long PlanoId { get; set; }

    public long? OrderId { get; set; }

    public string? UserId { get; set; }

    public string? Roles { get; set; }
}
