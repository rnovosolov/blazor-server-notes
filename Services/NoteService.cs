using BlazorServerNotes.Data;
using BlazorServerNotes.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Drawing.Printing;

namespace BlazorServerNotes.Services
{
    public class NoteService : INoteService
    {
        private readonly ApplicationDbContext _context;

        public NoteService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddNote(Note note)
        {
            // Service-side validation for tests
            if (nameof(note.Title) == null || note.Title == "")
            {
                throw new DbUpdateException("Title cannot be empty");
            }
            else if (note.Content == null || note.Content == "")
            {
                throw new DbUpdateException("Content cannot be empty");
            }
            else if (note.Created == null)
            {
                throw new DbUpdateException("Created cannot be empty");
            }
            else
            {
                note.Created = note.Created.ToUniversalTime();
                _context.Notes.Add(note);
                _context.SaveChanges();
            }
        }

        public void DeleteNote(int id)
        {
            var noteToDelete = _context.Notes.Find(id);

            if (noteToDelete != null)
            {
                _context.Notes.Remove(noteToDelete);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Note> GetNotes(int page, int pageSize)
        {
			return _context.Notes
		.OrderByDescending(note => note.Created) // Adjust the sorting as needed
		.Skip((page - 1) * pageSize)
		.Take(pageSize)
		.ToList();
		}

		public int GetTotalNotesCount()
		{
			return _context.Notes.Count();
		}

		public void UpdateNote(Note note)
        {
            // Service-side validation for tests
            if (nameof(note.Title) == null || note.Title == "")
            {
                throw new DbUpdateException("Title cannot be empty");
            }
            else if (note.Content == null || note.Content == "")
            {
                throw new DbUpdateException("Content cannot be empty");
            }
            else if (note.Created == null)
            {
                throw new DbUpdateException("Created cannot be empty");
            }
            else
            {
                var existingNote = _context.Notes.Local.FirstOrDefault(n => n.Id == note.Id);
                if (existingNote != null)
                {
                    _context.Entry(existingNote).State = EntityState.Detached;
                }

                _context.Notes.Update(note);
                _context.SaveChanges();
            }
        }

    }
}
