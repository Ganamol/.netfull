using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCLISTMODEL.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCLISTMODEL.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var student = new List<Student>()
            {
                new Student
                {
                    Id=1,Name="MANU",Mark=50,Mark1=50
                },
                new Student
                {
                    Id=2,Name="anu",Mark=20,Mark1=50
                },
                new Student
                {
                    Id=3,Name="anju",Mark=30,Mark1=50
                }
            };
            return View(student);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
