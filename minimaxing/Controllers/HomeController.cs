using Microsoft.AspNetCore.Mvc;

namespace minimaxing.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
