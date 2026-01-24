using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Jijie_Valentin_ProiectF1.Data;
using Jijie_Valentin_ProiectF1.Models;

namespace Jijie_Valentin_ProiectF1.Pages.Races
{
    public class DetailsModel : PageModel
    {
        private readonly Jijie_Valentin_ProiectF1.Data.Jijie_Valentin_ProiectF1Context _context;

        public DetailsModel(Jijie_Valentin_ProiectF1.Data.Jijie_Valentin_ProiectF1Context context)
        {
            _context = context;
        }

        public Race Race { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var race = await _context.Race.FirstOrDefaultAsync(m => m.ID == id);

            if (race is not null)
            {
                Race = race;

                return Page();
            }

            return NotFound();
        }
    }
}
