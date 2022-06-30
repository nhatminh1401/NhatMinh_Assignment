using API.Models.Products;
using app.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using Unipluss.Sign.ExternalContract.Entities;

namespace app.Pages
{
    public class PizzaModel : PageModel
    {
        
        private readonly HttpClient _http;
        public List<Product> DBProduct = new List<Product>();
        
       
        public async Task<IActionResult> OnGetAsync()
        {
            Console.WriteLine("1");
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7068/");
            

            var res = await client.GetAsync("api/Product");
            var result = res.Content.ReadAsStringAsync().Result;
            DBProduct = JsonConvert.DeserializeObject<List<Product>>(result);

           

            return Page();

        }

    }
}