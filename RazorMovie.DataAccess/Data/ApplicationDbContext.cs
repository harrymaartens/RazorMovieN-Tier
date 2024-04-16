using Microsoft.EntityFrameworkCore;
using RazorMovie.Models;


namespace RazorMovie.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; } = default!;
    }
}
