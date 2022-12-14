using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzarenaMenu.Models;

namespace PizzarenaMenu.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDb = new List<PizzasModel>()
        {
            new PizzasModel(){ PizzaName="Margerita",ImgTitle="Margerita", BasePrice=2 , Cheese=true , TomatoSauce=true , Price=10 },
            new PizzasModel(){ PizzaName="Mushroom",ImgTitle="Mushroom", BasePrice=2 , Cheese=true , Mushrom=true, Price=12},
            new PizzasModel(){ PizzaName="Carbonara",ImgTitle="Carbonara", BasePrice=2 , Cheese=true , Beef=true , Mushrom = true, Price=15},
            new PizzasModel(){ PizzaName="Bolognese",ImgTitle="Bolognese", BasePrice=2 , Cheese=true , TomatoSauce=true , Pepproni=true, Price = 16},
            new PizzasModel(){ PizzaName="Hawaiian",ImgTitle="Hawaiian", BasePrice=2 , Cheese=true , TomatoSauce=true , Pineapple = true, Price=17 },
            new PizzasModel(){ PizzaName="MeatFeast",ImgTitle="MeatFeast", BasePrice=2 , Cheese=true , TomatoSauce=true , Beef = true,Ham=true, Price=20},
            new PizzasModel(){ PizzaName="Pepperoni",ImgTitle="Pepperoni", BasePrice=2 , Cheese=true , TomatoSauce=true,Pepproni = true, Beef=true, Price = 14},
            new PizzasModel(){ PizzaName="Seafood",ImgTitle="Seafood", BasePrice=2 , Cheese=true , TomatoSauce=true, Pineapple=true,Tuna = true, Price = 25},
            new PizzasModel(){ PizzaName="Vegetarian",ImgTitle="Vegetarian", BasePrice=2 , Cheese=true , TomatoSauce=true,Pineapple=true,Mushrom = true , Price = 8},

        };
        public void OnGet()
        {

        }
    }
}
