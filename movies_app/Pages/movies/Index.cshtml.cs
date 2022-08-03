using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using movies_app.Data;
using movies_app.models;

namespace movies_app.Pages.movies
{
    public class IndexModel : PageModel
    {
        private readonly movies_app.Data.movies_appContext _context;

        public IndexModel(movies_app.Data.movies_appContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
}
