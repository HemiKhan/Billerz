using Microsoft.AspNetCore.Mvc;

namespace Billerz.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult LoginRegister()
        {
            return View();
        }
        public IActionResult MyAccount()
        {
            return View();
        }
    }
}
