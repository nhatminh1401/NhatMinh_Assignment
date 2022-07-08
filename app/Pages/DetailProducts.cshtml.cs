using API.Models.Products;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using API.Models;


namespace app.Pages
{
    public class DetailProductsModel : PageModel
    {
        private readonly HttpClient _http;
        public Product DBProduct = new Product();

        public Rating DbRating = new Rating();
        private int id;
        public async Task<IActionResult> OnGetAsync(int ProductID, int IdRate )
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7068/");

            
            
            this.id = ProductID;
            var res = await client.GetAsync("api/Product/" + id);
            var result = res.Content.ReadAsStringAsync().Result;
            DBProduct = JsonConvert.DeserializeObject<Product>(result);


            var rat = await client.GetAsync("api/Rating/" + id);
            var rates= rat.Content.ReadAsStringAsync().Result;
            DbRating = JsonConvert.DeserializeObject<Rating>(rates);

            return Page();

        }
        public async Task<IActionResult> OnPost(int ProductID, string Comment)
        {
            var i = int.Parse(Request.Form["star"]);
            var cmt = Request.Form["cmt"];
            
            return Page();
        }
       


    }
}