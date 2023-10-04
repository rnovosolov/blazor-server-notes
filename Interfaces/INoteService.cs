using BlazorServerNotes.Data;

namespace BlazorServerNotes.Interfaces
{
    public interface INoteService
    {
        IEnumerable<Note> GetNotes(int page, int pageSize);
        int GetTotalNotesCount();
		void AddNote(Note note);
        void UpdateNote(Note note);
        void DeleteNote(int id);
    }
}
