using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Jijie_Valentin_ProiectF1.Data;
using Jijie_Valentin_ProiectF1.Models;

namespace Jijie_Valentin_ProiectF1.Pages.Drivers
{
    public class DeleteModel : PageModel
    {
        private readonly Jijie_Valentin_ProiectF1.Data.Jijie_Valentin_ProiectF1Context _context;

        public DeleteModel(Jijie_Valentin_ProiectF1.Data.Jijie_Valentin_ProiectF1Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Driver Driver { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var driver = await _context.Driver.FirstOrDefaultAsync(m => m.ID == id);

            if (driver is not null)
            {
                Driver = driver;

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

            var driver = await _context.Driver.FindAsync(id);
            if (driver != null)
            {
                Driver = driver;
                _context.Driver.Remove(Driver);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
