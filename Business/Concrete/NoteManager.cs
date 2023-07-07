using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class NoteManager : INoteService
	{
		INoteDal _noteDal;

		public NoteManager(INoteDal noteDal)
		{
			_noteDal = noteDal;
		}

		public void AddNote(Note note)
		{
			if (note.Id != 0)
			{
				note.PredecessorNoteId = note.Id;
				note.Id = Convert.ToInt32(null);
			}
			note.NoteDate = DateTime.Now;
			note.Status = true;
			_noteDal.Add(note);
		}

		public void DeleteNote(Note note)
		{
			var updatedNote = GetById(note.Id);
			updatedNote.Status = false;
			_noteDal.Update(updatedNote);
		}

		public List<Note> GetAll()
		{
			return _noteDal.GetAll(n => n.Status == true);
		}

		public Note GetById(int noteId)
		{
			return _noteDal.Get(n => n.Id == noteId);
		}

		public void UpdateNote(Note note)
		{
			throw new NotImplementedException();
		}
	}
}