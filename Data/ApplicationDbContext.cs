using BlazorServerNotes.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerNotes.Data
{
    public class ApplicationDbContext : DbContext//, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<Note> Notes { get; set; }
    }
}
