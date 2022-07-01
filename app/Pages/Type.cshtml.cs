//using API.Models.Products;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.RazorPages;
//using Newtonsoft.Json;

//namespace app.Pages
//{
//    public class TypeModel : PageModel
//    {
//        private readonly HttpClient _http;
//        public List<Product> DBProduct = new List<Product>();
//        private int categoryId;
//        public async Task<IActionResult> OnGetAsync(int ProductID)
//        {
//            var client = new HttpClient();
//            client.BaseAddress = new Uri("https://localhost:7068/");

//            string a = "";

//            this.categoryId = ProductID;
//            var res = await client.GetAsync("api/Product/" + categoryId);
//            var result = res.Content.ReadAsStringAsync().Result;
//            DBProduct = JsonConvert.DeserializeObject<List<Product>>(result);


//            return Page();

//        }
//    }
//}