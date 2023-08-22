using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace coreproject.Controllers
{
    public class Add : Controller
    {
        public string Index()
        {
            return "hello";
        }
        //public string welcome()
        //{
        //    return "welcome";
        //}
        //public string welcome(string name="anu",int num=1)

        //{
        //    return HtmlEncoder.Default.Encode($"hello{name},number is{ num }");

        //}
        public IActionResult Welcome(string name="anu",int num=1)
        {
            //ViewData["message"] = "hello" + name;
            //ViewData["number"]="number"+num;
            ViewBag.message = "hello" + name;
            ViewBag.number = "number" + num;
            return View();
        }
    }
}
