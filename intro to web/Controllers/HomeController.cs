using Microsoft.AspNetCore.Mvc;

namespace intro_to_web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
