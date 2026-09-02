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
    ApproveOrder = 12,
    DeletePlano = 13,
    RenamePlano = 14,
    ValidatePlano = 15,
    ArchivePlano = 16,
    RejectPlano = 17,
    RestorePlano = 18,
    CreateLayout = 19,
    EditLayout = 20,


}

public partial class AuditLog : BaseEntity<long>, IAggregateRoot
{

    public DateTime Date { get; set; }

    public string Message { get; set; } = null!;

    public int? LegacyUserId { get; set; }

    public int? BrandId { get; set; }
    public string? BrandName { get; set; }

    public string? UserName { get; set; }

    public int? Action { get; set; }
    public string? ActionName { get; set; }
    public int? ActionType { get; set; }
    public long PlanoId { get; set; }
    public string? PlanoName { get; set; }
    public long? OrderId { get; set; }
    public string? OrderName { get; set; }

    public string? UserId { get; set; }
    public string? Roles { get; set; }
    public int? RoleId { get; set; }
    public string? RoleName { get; set; }
    public int? RegionId { get; set; }
    public string? RegionName { get; set; }
    public int? CountryId { get; set; }
    public string? CountryName { get; set; }
}
