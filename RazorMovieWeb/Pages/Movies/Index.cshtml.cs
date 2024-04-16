using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorMovie.Models;

namespace RazorMovie.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly DataAccess.Data.ApplicationDbContext _context;

        public IndexModel(DataAccess.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
