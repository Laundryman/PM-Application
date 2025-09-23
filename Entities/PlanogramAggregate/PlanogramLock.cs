using PMApplication.Interfaces;

namespace PMApplication.Entities.PlanogramAggregate;

public partial class PlanogramLock : BaseEntity<long>, IAggregateRoot
{
    public int LegacyUserId { get; set; }

    public bool Locked { get; set; }

    public DateTime DateOpened { get; set; }

    public DateTime? DateClosed { get; set; }

    public long PlanogramId { get; set; }

    public string? UserId { get; set; }

    public string? Username { get; set; }
}
