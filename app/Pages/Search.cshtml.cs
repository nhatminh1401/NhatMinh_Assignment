using API.Models.Products;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace app.Pages
{
    public class SearchModel : PageModel
    {
        private readonly HttpClient _http;
        public Product DBProduct = new Product();
        public async Task<IActionResult> OnGetAsync(string keyword)
        {
            if (!string.IsNullOrEmpty(keyword))
            {
                ViewData["Data"] = keyword;
                //var client = new HttpClient();
                //client.BaseAddress = new Uri("https://localhost:7068/");

                //string a = "";


                //var res = await client.GetAsync("api/Product/Search/" + keyword);
                //var result = res.Content.ReadAsStringAsync().Result;
                //DBProduct = JsonConvert.DeserializeObject<Product>(result);
                return Page();
            }
           
            return RedirectToPage("Index");
        }
    }
}
