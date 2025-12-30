using Microsoft.AspNetCore.Mvc;

namespace UrlOpener.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
