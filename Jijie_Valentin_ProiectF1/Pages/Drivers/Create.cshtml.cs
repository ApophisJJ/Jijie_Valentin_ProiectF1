using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Jijie_Valentin_ProiectF1.Data;
using Jijie_Valentin_ProiectF1.Models;

namespace Jijie_Valentin_ProiectF1.Pages.Drivers
{
    public class CreateModel : PageModel
    {
        private readonly Jijie_Valentin_ProiectF1.Data.Jijie_Valentin_ProiectF1Context _context;

        public CreateModel(Jijie_Valentin_ProiectF1.Data.Jijie_Valentin_ProiectF1Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["TeamID"] = new SelectList(_context.Team, "ID", "TeamName");
            return Page();
        }

        [BindProperty]
        public Driver Driver { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                ViewData["TeamID"] = new SelectList(
                    _context.Team,
                    "ID",
                    "TeamName"
                );
                return Page();
            }

            _context.Driver.Add(Driver);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
