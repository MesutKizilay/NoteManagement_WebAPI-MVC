using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface INoteService
    {
        List<Note> GetAll();
        Note GetById(int noteId);
        void Add(Note Note);
        void Update(Note Note);
        void Delete(Note Note);
    }
}