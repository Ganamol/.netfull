using asp.netcoremodel.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp.netcoremodel.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Student s = new Student()
            {
                Id = 1,
                name = "anu",
                marks=20
            };
            return View(s);
        }
    }
}
