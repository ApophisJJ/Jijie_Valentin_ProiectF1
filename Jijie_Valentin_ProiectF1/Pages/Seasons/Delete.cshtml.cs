using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Jijie_Valentin_ProiectF1.Data;
using Jijie_Valentin_ProiectF1.Models;

namespace Jijie_Valentin_ProiectF1.Pages.Seasons
{
    public class DeleteModel : PageModel
    {
        private readonly Jijie_Valentin_ProiectF1.Data.Jijie_Valentin_ProiectF1Context _context;

        public DeleteModel(Jijie_Valentin_ProiectF1.Data.Jijie_Valentin_ProiectF1Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Season Season { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var season = await _context.Season.FirstOrDefaultAsync(m => m.ID == id);

            if (season is not null)
            {
                Season = season;

                return Page();
            }

            return NotFound();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var season = await _context.Season.FindAsync(id);
            if (season != null)
            {
                Season = season;
                _context.Season.Remove(Season);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
