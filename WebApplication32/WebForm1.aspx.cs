using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication32
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        Class1 c = new Class1();

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = c.add().ToString();

        }
     
        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox2.Text = c.sub().ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
        

        }
    }
}