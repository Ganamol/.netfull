using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coretoday.Controller
{
    public class SiteController : ControllerBase
    {
        public string Index()
        {
            return "site";
        }
        public int Add()
        {
            return 12+3;
        }
        public int sub()
        {
            return 12 - 3;
        }
    }
}
