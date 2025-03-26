using noteApp.Models;

namespace noteApp.Services
{
    public class NoteService
    {
        private readonly List<Note> _notes = new List<Note>();
        public NoteService()
        {
            
        }

        public IEnumerable<Note> GetNotes()
        {
            return _notes;
        }

        public Note AddNote(Note note)
        {
            _notes.Add(note);
            return note;
        }
        
    }
}