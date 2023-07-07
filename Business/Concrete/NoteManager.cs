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

        public void Add(Note Note)
        {
            throw new NotImplementedException();
        }

        public void Delete(Note Note)
        {
            throw new NotImplementedException();
        }

        public List<Note> GetAll()
        {
            return _noteDal.GetAll();
        }

        public Note GetById(int noteId)
        {
            throw new NotImplementedException();
        }

        public void Update(Note Note)
        {
            throw new NotImplementedException();
        }
    }
}