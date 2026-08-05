using System;
using System.Collections.Generic;
using System.Text;

namespace PMApplication.Dtos.Notes
{
    public class PlanogramNoteDto
    {
        public long? Id { get; set; }
        public string? Note { get; set; }

        public int? LegacyUserId { get; set; }

        public DateTime? NoteDate { get; set; }

        public long? PlanogramNote_NoteId { get; set; }

        public string? NoteTitle { get; set; }

        public long PlanogramId { get; set; }

        public long? NoteInReplyTo { get; set; }

        public string? UserId { get; set; }

        public string? Username { get; set; }

        public List<PlanogramNoteDto>? PlanogramNotes { get; set; } = new List<PlanogramNoteDto>();
        //public PlanogramNoteDto? PlanogramNoteInReplyTo { get; set; }
    }
}
