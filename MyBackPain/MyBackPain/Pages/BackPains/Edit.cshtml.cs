using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyBackPain.Data;
using MyBackPain.Models;

namespace MyBackPain.Pages.BackPains
{
    public class EditModel : PageModel
    {
        private readonly MyBackPain.Data.MyBackPainContext _context;

        public EditModel(MyBackPain.Data.MyBackPainContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(BackPain).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BackPainExists(BackPain.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool BackPainExists(int id)
        {
            return _context.BackPain.Any(e => e.ID == id);
        }
    }
}
