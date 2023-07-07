using Microsoft.AspNetCore.Mvc;

namespace NoteManagement.Controllers
{
    public class NotesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
