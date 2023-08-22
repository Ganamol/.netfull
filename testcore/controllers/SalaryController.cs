using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testcore.controllers
{
    public class SalaryController : Controller
    {
        public int sal()
        {
            int s=6;

            return s*s;
        }
    }
}
