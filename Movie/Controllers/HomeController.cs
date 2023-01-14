using Microsoft.AspNetCore.Mvc;

namespace Movie.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
