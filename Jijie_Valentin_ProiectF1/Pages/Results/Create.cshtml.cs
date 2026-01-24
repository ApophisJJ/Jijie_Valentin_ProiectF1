using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Jijie_Valentin_ProiectF1.Data;
using Jijie_Valentin_ProiectF1.Models;

namespace Jijie_Valentin_ProiectF1.Pages.Results
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
        ViewData["DriverID"] = new SelectList(_context.Driver, "ID", "FirstName");
        ViewData["RaceID"] = new SelectList(_context.Race, "ID", "RaceName");
            return Page();
        }

        [BindProperty]
        public Result Result { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Result.Add(Result);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
