using Microsoft.AspNetCore.Mvc;

namespace WebApplication10
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
