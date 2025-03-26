using Microsoft.AspNetCore.Mvc;
using noteApp.Models;
using noteApp.Services;

namespace noteApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NoteController: ControllerBase
    {
        private readonly NoteService _noteService;
        public NoteController(NoteService noteService)
        {
            _noteService = noteService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Note>> GetAll()
        {
            var notes = _noteService.GetNotes();
            return Ok(notes);
        }

        [HttpPost]
        public ActionResult<Note> Create(Note note)
        {
            var createdNote = _noteService.AddNote(note);
            return Ok(note);
        }
    }
}