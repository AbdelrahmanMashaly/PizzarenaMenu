using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzarenaMenu.Data;
using PizzarenaMenu.Models;

namespace PizzarenaMenu.Pages
{
    public class OrdersModel : PageModel
    {
        private readonly ApplicationDb context;
        public List<PizzaOrder> pizzaOrders= new List<PizzaOrder>();

        public OrdersModel(ApplicationDb context)
        {
            this.context = context;
        }
        public void OnGet()
        {
           pizzaOrders = context.orders.ToList();
        }
    }
}
