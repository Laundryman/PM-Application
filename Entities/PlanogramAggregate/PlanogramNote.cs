using System.ComponentModel.DataAnnotations.Schema;
using PMApplication.Interfaces;

namespace PMApplication.Entities.PlanogramAggregate;

public partial class PlanogramNote : BaseEntity<long>, IAggregateRoot
{
    public string? Note { get; set; }

    public int? LegacyUserId { get; set; }

    public DateTime? NoteDate { get; set; }

    public long? PlanogramNote_NoteId { get; set; }

    public string? NoteTitle { get; set; }

    public long PlanogramId { get; set; }

    public long? NoteInReplyTo { get; set; }

    public string? UserId { get; set; }

    public string? Username { get; set; }


    public virtual List<PlanogramNote> PlanogramNotes { get; set; }

    public virtual Planogram Planogram { get; set; } = null!;

    //[ForeignKey("NoteInReplyTo")]
    //[InverseProperty(nameof(PlanogramNote.PlanogramNotes))]
    public virtual PlanogramNote? PlanogramNoteInReplyTo { get; set; }
}
