using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace testcore.controllers
{
    public class HomeController : Controller
    {
        public int Index()
        {
            int a = 10, b = 5;
            return a+b;
        }
        public string welcome(string name="anu",int num=1)
        {
            return HtmlEncoder.Default.Encode($"hello{name},number is {num}");
        }
    }
}
