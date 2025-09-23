using PMApplication.Interfaces;

namespace PMApplication.Entities.PlanogramAggregate;

public partial class PlanogramNote : BaseEntity<long>, IAggregateRoot
{
    public string? Note { get; set; }

    public int? LegacyUserId { get; set; }

    public DateTime? NoteDate { get; set; }

    public long? PlanogramNoteNoteId { get; set; }

    public string? NoteTitle { get; set; }

    public long PlanogramId { get; set; }

    public long? NoteInReplyTo { get; set; }

    public string? UserId { get; set; }

    public string? Username { get; set; }

    public virtual ICollection<PlanogramNote> InversePlanogramNoteNote { get; set; } = new List<PlanogramNote>();

    public virtual Planogram Planogram { get; set; } = null!;

    public virtual PlanogramNote? PlanogramNoteNote { get; set; }
}
