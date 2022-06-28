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
    public class DetailsModel : PageModel
    {
        private readonly app.Data.ApplicationDbContext _context;

        public DetailsModel(app.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public PizzaCategory PizzaCategory { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PizzaCategory = await _context.PizzaCategories.FirstOrDefaultAsync(m => m.Id == id);

            if (PizzaCategory == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
