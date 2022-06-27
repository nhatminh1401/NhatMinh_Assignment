using app.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace app.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }
        public float PizzaPrice { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;

            if (Pizza.TomatoSauce) PizzaPrice += 1;
            if (Pizza.Cheese) PizzaPrice += 8;
            if (Pizza.Tuna) PizzaPrice += 1;
            if (Pizza.Beef) PizzaPrice += 10;
            if (Pizza.Ham) PizzaPrice += 4;
            if (Pizza.Pineapple) PizzaPrice += 6;
            if (Pizza.Mushroom) PizzaPrice += 5;
            if (Pizza.Peperoni) PizzaPrice += 1;
            
            return RedirectToPage("/Checkout/Checkout", new { Pizza.PizzaName, PizzaPrice});
        }
    }
}
