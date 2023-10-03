using System.ComponentModel.DataAnnotations;

namespace BlazorServerNotes.Data
{
    public class Note
    {
        public int Id { get; set; }
		[Required(ErrorMessage = "Title is required.")]
		public string Title { get; set; }
		[Required(ErrorMessage = "Content is required.")]
		public string Content { get; set; }
        public DateTime Created { get; set; }

    }
}
