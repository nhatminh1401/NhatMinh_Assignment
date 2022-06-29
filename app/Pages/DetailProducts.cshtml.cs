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
        //public List<ProductVariant> DBProductVariants = new List<ProductVariant>();

        // private APIHelper _api = new APIHelper();
        private int id;
        public async Task<IActionResult> OnGetAsync(int ProductID)
        {
            //Console.WriteLine("1");
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7068/");

            //  id = "1";
            string a = "";
            
            //var result = await _http.GetFromJsonAsync<IActionResult<Product>>($"api/product");
            this.id = ProductID;
            var res = await client.GetAsync("api/Product/" + id);
            var result = res.Content.ReadAsStringAsync().Result;
            DBProduct = JsonConvert.DeserializeObject<Product>(result);
            //Console.WriteLine(DBProduct);

           /* var resV = await client.GetAsync("api/ProductVariants/");
            var resultV = resV.Content.ReadAsStringAsync().Result;*/
            //DBProductVariants = JsonConvert.DeserializeObject<List<ProductVariant>>(resultV);

            return Page();

        }

    }
}