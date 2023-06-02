using Microsoft.AspNetCore.Mvc;

namespace Billerz.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Products()
        {
            return View();
        }

        public IActionResult ProductDetail()
        {
            return View();
        }
    }
}
