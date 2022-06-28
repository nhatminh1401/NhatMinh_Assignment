using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using app.Data;
using app.Models;

namespace app.Pages.Category
{
    public class EditModel : PageModel
    {
        private readonly app.Data.ApplicationDbContext _context;

        public EditModel(app.Data.ApplicationDbContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(PizzaCategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PizzaCategoryExists(PizzaCategory.Id))
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

        private bool PizzaCategoryExists(int id)
        {
            return _context.PizzaCategories.Any(e => e.Id == id);
        }
    }
}
