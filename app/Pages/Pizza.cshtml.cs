using app.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace app.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>() 
        {
            new PizzasModel(){
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
        } ;
        public void OnGet()
        {
        }
    }
}
