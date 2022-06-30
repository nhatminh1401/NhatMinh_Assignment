using API.Models.Products;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace app.Pages
{
    public class DetailProductsModel : PageModel
    {
        private readonly HttpClient _http;
        public Product DBProduct = new Product();
        private int id;
        public async Task<IActionResult> OnGetAsync(int ProductID)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7068/");

            string a = "";
            
            this.id = ProductID;
            var res = await client.GetAsync("api/Product/" + id);
            var result = res.Content.ReadAsStringAsync().Result;
            DBProduct = JsonConvert.DeserializeObject<Product>(result);
            

            return Page();

        }

    }
}