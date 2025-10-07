using PMApplication.Interfaces;

namespace PMApplication.Entities;

public partial class Email : BaseEntity<int>, IAggregateRoot
{
    public bool EmailEnabled { get; set; }

    public string FromAddress { get; set; } = null!;

    public string ToAddress { get; set; } = null!;

    public string RecipientName { get; set; } = null!;

    public string EmailSubject { get; set; } = null!;

    public string? BccList { get; set; }

    public bool? EmailSendSuccess { get; set; }

    public int? EmailTrigger { get; set; }

    public string? BrandName { get; set; }

    public int LegacyUserId { get; set; }

    public int? PlanogramId { get; set; }

    public DateTime DateSent { get; set; }

    public string? CcList { get; set; }

    public string? SuppliedEmailAddress { get; set; }

    public string? SuppliedName { get; set; }

    public string? SuppliedEmailBodyContent { get; set; }

    public int? OrderId { get; set; }

    public string? UserId { get; set; }

    public string? Username { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? CountryName { get; set; }
}
