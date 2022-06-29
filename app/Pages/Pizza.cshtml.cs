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
        /*public List<PizzasModel> fakePizzaDB = new List<PizzasModel>() 
        {*/
            /*new PizzasModel(){
                ImageTitle="Margerita",
                PizzaName="Margerita",
                BasePrice = 3,
                TomatoSauce= true ,
                Cheese = true ,
                FinalPrice = 4},

            new PizzasModel(){
                ImageTitle="Bolognese",
                PizzaName="Bolognese",
                BasePrice = 4,
                TomatoSauce= true ,
                Cheese = true ,
                FinalPrice = 8},

            new PizzasModel(){
                ImageTitle="Carbonara",
                PizzaName="Carbonara",
                BasePrice = 3,
                TomatoSauce= true ,
                Cheese = true ,
                FinalPrice = 7},

            new PizzasModel(){
                ImageTitle="Hawaiian",
                PizzaName="Hawaiian",
                BasePrice = 3,
                TomatoSauce= true ,
                Cheese = true ,
                FinalPrice = 8},

            new PizzasModel(){
                ImageTitle="MeatFeast",
                PizzaName="MeatFeast",
                BasePrice = 4,
                TomatoSauce= true ,
                Cheese = true ,
                FinalPrice = 8},

            new PizzasModel(){
                ImageTitle="Mushroom",
                PizzaName="Mushroom",
                BasePrice = 3,
                TomatoSauce= true ,
                Cheese = true ,
                FinalPrice = 7},

            new PizzasModel(){
                ImageTitle="Pepperoni",
                PizzaName="Pepperoni",
                BasePrice = 3,
                TomatoSauce= true ,
                Cheese = true ,
                FinalPrice = 4},

            new PizzasModel(){
                ImageTitle="Seafood",
                PizzaName="Seafood",
                BasePrice = 4,
                TomatoSauce= true ,
                Cheese = true ,
                FinalPrice = 8},

            new PizzasModel(){
                ImageTitle="Vegetarian",
                PizzaName="Vegetarian",
                BasePrice = 3,
                TomatoSauce= true ,
                Cheese = true ,
                FinalPrice = 7},
        } ;*/
        private readonly HttpClient _http;
        public List<Product> DBProduct = new List<Product>();
        //public List<ProductVariant> DBProductVariants = new List<ProductVariant>();

        // private APIHelper _api = new APIHelper();
       
        public async Task<IActionResult> OnGetAsync()
        {
            Console.WriteLine("1");
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7068/");
            //var result = await _http.GetFromJsonAsync<IActionResult<Product>>($"api/product");
            var res = await client.GetAsync("api/Product");
            var result = res.Content.ReadAsStringAsync().Result;
            DBProduct = JsonConvert.DeserializeObject<List<Product>>(result);

            //var resV = await client.GetAsync("api/ProductVariants");
           // var resultV = resV.Content.ReadAsStringAsync().Result;
            //DBProductVariants = JsonConvert.DeserializeObject<List<ProductVariant>>(resultV);

            return Page();

        }

    }
}