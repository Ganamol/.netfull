using Microsoft.AspNetCore.Mvc;
using model21_6_23.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace model21_6_23.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Student s = new Student()
            {
                Id = 1,
                Name = "hiran",
                Mark = 22
            };
            return View(s);
        }
    }
}
