using API.Models.Products;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace app.Pages.Categories
{
    public class tinhcamModel : PageModel
    {
        private readonly HttpClient _http;

        public List<Product> DBProduct = new List<Product>();

        public List<Product> ProductCategory = new List<Product>();
        private int id;
        public async Task<IActionResult> OnGetAsync(int CategoryID)
        {
            /*Console.WriteLine("1");*/
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7068/");

            var res = await client.GetAsync("api/Product");
            var result = res.Content.ReadAsStringAsync().Result;
            DBProduct = JsonConvert.DeserializeObject<List<Product>>(result);

            this.id = CategoryID;
            var cid = await client.GetAsync("api/Product/category/" + id);
            var CId = cid.Content.ReadAsStringAsync().Result;
            ProductCategory = JsonConvert.DeserializeObject<List<Product>>(CId);


            return Page();

        }
    }
}
