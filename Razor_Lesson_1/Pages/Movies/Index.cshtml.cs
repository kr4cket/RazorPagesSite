using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Razor_Lesson_1.Data;
using Razor_Lesson_1.Models;

namespace Razor_Lesson_1.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly Razor_Lesson_1.Data.Razor_Lesson_1Context _context;

        public IndexModel(Razor_Lesson_1.Data.Razor_Lesson_1Context context)
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
