using Microsoft.AspNetCore.Mvc;

namespace WebApplicationPronia.Controllers
{
    public class ShopController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
        public async Task<IActionResult> AboutUs()
        {
            return View();
        }
    }
}
