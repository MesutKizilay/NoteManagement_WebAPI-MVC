using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        INoteService _noteService;

        public NotesController(INoteService noteService)
        {
            _noteService = noteService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result=_noteService.GetAll();
            return Ok(result);
        }

        [HttpPost("deletenote")]
        public IActionResult DeleteNote(Note note)
        {
            _noteService.DeleteNote(note);
            return Ok();
        }

        [HttpPost("addnote")]        
        public IActionResult AddNote(Note note)
        {
            _noteService.AddNote(note);
            return Ok();
        }
    }
}