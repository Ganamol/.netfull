using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testcore.controllers
{
    public class EmployeeController : Controller
    {
        public string emp()
        {
            string empname = "gana";
            return "name is"+empname;
        }
    }
}
