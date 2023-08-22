using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace coretoday.Controller
{
    public class welcomeController : ControllerBase
    {
        public string display(string name="anu",int num=1)
        {
            return HtmlEncoder.Default.Encode($"hello{name},number is{num}");
        }
    }
}
