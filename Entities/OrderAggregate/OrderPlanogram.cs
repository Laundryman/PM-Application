using PMApplication.Interfaces;

namespace PMApplication.Entities.OrderAggregate;

public partial class OrderPlanogram : BaseEntity<int>, IAggregateRoot
{

    public int? OrderId { get; set; }

    public int? PlanogramId { get; set; }

    public DateTime? DateAdded { get; set; }

    public int? LegacyUserId { get; set; }

    public bool? IsFullPlano { get; set; }

    public string? UserId { get; set; }

    public string? Username { get; set; }
}
