using Microsoft.AspNetCore.Mvc;
using Modeltest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modeltest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Student s = new Student()
            {
                Id = 1,
                name = "gaana",
                marks = 12
            };
            return View(s);
        }
    }
}
