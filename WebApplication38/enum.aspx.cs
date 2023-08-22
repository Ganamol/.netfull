using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication38
{
    public partial class _enum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        enum car
        {
            red,
            Tata,
            model
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            car myVar = car.red;
                
            TextBox1.Text = myVar.ToString();
        }
      
    }
}