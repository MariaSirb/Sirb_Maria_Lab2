using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sirb_Maria_Lab2.Data;
using Sirb_Maria_Lab2.Models;

namespace Sirb_Maria_Lab2.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Sirb_Maria_Lab2.Data.Sirb_Maria_Lab2Context _context;

        public IndexModel(Sirb_Maria_Lab2.Data.Sirb_Maria_Lab2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Publisher != null)
            {
                Publisher = await _context.Publisher.ToListAsync();
            }
        }
    }
}
