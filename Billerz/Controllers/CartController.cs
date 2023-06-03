using Microsoft.AspNetCore.Mvc;

namespace Billerz.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult EmptyCart()
        {
            return View();
        }
    }
}
