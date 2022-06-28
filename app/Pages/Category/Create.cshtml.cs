using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using app.Data;
using app.Models;

namespace app.Pages.Category
{
    public class CreateModel : PageModel
    {
        private readonly app.Data.ApplicationDbContext _context;

        public CreateModel(app.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public PizzaCategory PizzaCategory { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.PizzaCategories.Add(PizzaCategory);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
