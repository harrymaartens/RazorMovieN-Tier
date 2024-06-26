﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorMovie.Models;

namespace RazorMovie.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly DataAccess.Data.ApplicationDbContext _context;

        public DetailsModel(DataAccess.Data.ApplicationDbContext context)
        {
            _context = context;
        }
                
        public Movie Movie { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie.FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }
            else
            {
                Movie = movie;
            }
            return Page();
        }
    }
}
