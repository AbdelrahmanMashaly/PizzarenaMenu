using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PizzarenaMenu.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {
        public string PizzaName { get; set; }
        public float PizzaPrice { get; set; }
        public string ImgTitle { get; set; }
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
        }
    }
}
