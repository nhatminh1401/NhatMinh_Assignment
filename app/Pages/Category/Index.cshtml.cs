using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using app.Data;
using app.Models;

namespace app.Pages.Category
{
    public class IndexModel : PageModel
    {
        private readonly app.Data.ApplicationDbContext _context;

        public IndexModel(app.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<PizzaCategory> PizzaCategory { get;set; }

        public async Task OnGetAsync()
        {
            PizzaCategory = await _context.PizzaCategories.ToListAsync();
        }
    }
}
