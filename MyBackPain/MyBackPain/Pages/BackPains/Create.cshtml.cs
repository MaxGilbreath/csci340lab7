using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyBackPain.Data;
using MyBackPain.Models;

namespace MyBackPain.Pages.BackPains
{
    public class CreateModel : PageModel
    {
        private readonly MyBackPain.Data.MyBackPainContext _context;

        public CreateModel(MyBackPain.Data.MyBackPainContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public BackPain BackPain { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.BackPain.Add(BackPain);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
