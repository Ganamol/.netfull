using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coretoday.Controller
{
    public class HomeController : ControllerBase
    {
        public int Add()
        {
            int a = 2;
            int b = 3;
            int c = a + b;
            return c;
        }
      




    }
}
