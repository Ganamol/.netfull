using corefirst.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace corefirst.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //ViewData["msg"] = "viewdata";
            //ViewBag.message = "viewbag";
            var Students = new List<Student>()
            {

           new Student
            {
                Id = 1,
                Name = "Gana",
                marks = 12
            },
             new Student
            {
                Id = 1,
                Name = "Gana",
                marks = 12
            }
            };
        
            return View(Students);
        }

        public IActionResult Welcome()
        {
            return View();
        }
    }
}
