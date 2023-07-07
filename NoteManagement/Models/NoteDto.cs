using System;

namespace NoteManagement.Models
{
    public class NoteDto
    {
        public int Id { get; set; }
        public int? PredecessorNoteId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime? NoteDate { get; set; }
        public bool Status { get; set; }
    }
}