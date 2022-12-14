using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzarenaMenu.Models;

namespace PizzarenaMenu.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }

        public float PizzaPrice { get; set; }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;
            if (Pizza.TomatoSauce) PizzaPrice += 1;
            if (Pizza.Cheese) PizzaPrice += 4;
            if (Pizza.Pepproni) PizzaPrice +=4;
            if (Pizza.Pineapple) PizzaPrice += 2;
            if (Pizza.Mushrom) PizzaPrice += 1;
            if (Pizza.Tuna) PizzaPrice += 3;
            if (Pizza.Beef) PizzaPrice += 5;
            if (Pizza.Ham) PizzaPrice += 6;

            return RedirectToPage("/Checkout/Checkout" , new {Pizza.PizzaName , PizzaPrice});
        }
    }
}
