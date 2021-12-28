using Microsoft.AspNetCore.Mvc;

namespace Task22_12_2021.Areas.admin.Controllers
{
    [Area("admin")]
    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
    }
}
