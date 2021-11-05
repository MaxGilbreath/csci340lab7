using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyBackPain.Data;
using MyBackPain.Models;

namespace MyBackPain.Pages.BackPains
{
    public class DetailsModel : PageModel
    {
        private readonly MyBackPain.Data.MyBackPainContext _context;

        public DetailsModel(MyBackPain.Data.MyBackPainContext context)
        {
            _context = context;
        }

        public BackPain BackPain { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BackPain = await _context.BackPain.FirstOrDefaultAsync(m => m.ID == id);

            if (BackPain == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
