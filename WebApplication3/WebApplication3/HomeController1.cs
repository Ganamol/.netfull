using Microsoft.AspNetCore.Mvc;

namespace WebApplication3
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
