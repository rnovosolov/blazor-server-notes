using BlazorServerNotes.Data;

namespace BlazorServerNotes.Interfaces
{
    public interface INoteService
    {
        IEnumerable<Note> GetNotes();
        //Note GetNote(int id);
        void AddNote(Note note);
        void UpdateNote(Note note);
        void DeleteNote(int id);
    }
}
