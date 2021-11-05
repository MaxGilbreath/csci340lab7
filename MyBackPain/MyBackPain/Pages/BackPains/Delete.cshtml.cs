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
    public class DeleteModel : PageModel
    {
        private readonly MyBackPain.Data.MyBackPainContext _context;

        public DeleteModel(MyBackPain.Data.MyBackPainContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BackPain = await _context.BackPain.FindAsync(id);

            if (BackPain != null)
            {
                _context.BackPain.Remove(BackPain);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
