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
    public class IndexModel : PageModel
    {
        private readonly MyBackPain.Data.MyBackPainContext _context;

        public IndexModel(MyBackPain.Data.MyBackPainContext context)
        {
            _context = context;
        }

        public IList<BackPain> BackPain { get;set; }

        public async Task OnGetAsync()
        {
            BackPain = await _context.BackPain.ToListAsync();
        }
    }
}
