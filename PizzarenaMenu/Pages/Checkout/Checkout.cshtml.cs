using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzarenaMenu.Data;
using PizzarenaMenu.Models;

namespace PizzarenaMenu.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {
        private readonly ApplicationDb context;

        public string PizzaName { get; set; }
        public float PizzaPrice { get; set; }
        public string ImgTitle { get; set; }

        public CheckoutModel(ApplicationDb context)
        {
            this.context = context;
        }
        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(ImgTitle))
            {
                ImgTitle = "Create";
            }
            if (string.IsNullOrWhiteSpace(PizzaName))
            {
                PizzaName = "Custom";
            }

            PizzaOrder pizzaOrder = new PizzaOrder();
            pizzaOrder.PizzaName = PizzaName;
            pizzaOrder.BasePrice = PizzaPrice;

            context.orders.Add(pizzaOrder);
            context.SaveChanges();

        }
    }
}
