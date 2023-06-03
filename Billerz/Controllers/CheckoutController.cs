using Microsoft.AspNetCore.Mvc;

namespace Billerz.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Checkout()
        {
            return View();
        }
    }
}
