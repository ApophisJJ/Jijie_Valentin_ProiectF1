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
    public class IndexModel : PageModel
    {
        private readonly Jijie_Valentin_ProiectF1.Data.Jijie_Valentin_ProiectF1Context _context;

        public IndexModel(Jijie_Valentin_ProiectF1.Data.Jijie_Valentin_ProiectF1Context context)
        {
            _context = context;
        }

        public IList<Season> Season { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Season = await _context.Season.ToListAsync();
        }
    }
}
