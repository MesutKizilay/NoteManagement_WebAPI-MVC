﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Note:IEntity
    {
        public int Id { get; set; }
        public int? PredecessorNoteId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime? NoteDate { get; set; }
		public bool Status { get; set; }
	}
}