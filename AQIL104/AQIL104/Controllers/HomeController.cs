using Microsoft.AspNetCore.Mvc;

namespace AQIL104.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }




        public IActionResult About()
        {
            return View();
        }
    }
}
