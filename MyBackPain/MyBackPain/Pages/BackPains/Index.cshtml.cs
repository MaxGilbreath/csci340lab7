using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyBackPain.Data;
using MyBackPain.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

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
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Looks { get; set; }
        [BindProperty(SupportsGet = true)]
        public string DoIShakeMyFistsAtTheSky { get; set; }
        public async Task OnGetAsync()
        {
            var pains = from m in _context.BackPain
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                pains = pains.Where(s => s.DoIHaveBackPain.Contains(SearchString));
            }
            BackPain = await _context.BackPain.ToListAsync();
        }
    }
}
