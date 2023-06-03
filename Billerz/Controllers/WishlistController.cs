using Microsoft.AspNetCore.Mvc;

namespace Billerz.Controllers
{
    public class WishlistController : Controller
    {
        public IActionResult Wishlist()
        {
            return View();
        }
    }
}
