using Microsoft.AspNetCore.Mvc;

namespace Task22_12_2021.Areas.admin.Controllers
{
    public class BlogCategoryController : Controller
    {
        [Area("admin")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
