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
    public class DeleteModel : PageModel
    {
        private readonly app.Data.ApplicationDbContext _context;

        public DeleteModel(app.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PizzaCategory = await _context.PizzaCategories.FindAsync(id);

            if (PizzaCategory != null)
            {
                _context.PizzaCategories.Remove(PizzaCategory);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
