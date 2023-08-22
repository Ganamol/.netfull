using Microsoft.AspNetCore.Mvc;
using model21_6_23.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace model21_6_23.Controllers
{
    public class HelloController : Controller
    {

        public IActionResult Index()
        {
            var student = new List<Student>()
            {
                new Student
                {
                    Id=1,Name="anu",Mark=20
                },
            new Student
            {
                Id = 2,
                Name = "anu",
                Mark = 30
            },
              new Student
            {
                Id = 3,
                Name = "minnnu",
                Mark = 40
            },
                new Student
            {
                Id = 1,
                Name = "anju",
                Mark = 50
            }
            };
               return View(student);
        }
         
        
    }
}

