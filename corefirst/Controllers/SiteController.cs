using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace corefirst.Controllers
{
    public class SiteController : Controller
    {
        public string site()
        {
            return "welcome site";
        }
    }
}
