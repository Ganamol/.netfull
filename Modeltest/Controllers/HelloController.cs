using Microsoft.AspNetCore.Mvc;
using Modeltest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modeltest.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            var students=new List<Student>()
            { 
             new Student()
            {
                Id = 1,
                name = "gaana",
                marks = 12
            },
              new Student()
            {
                Id = 1,
                name = "gaana",
                marks = 12
            },
            };
            return View(students);
            
        }
    }
}
