using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication19
{
    
    public partial class WebForm1 : System.Web.UI.Page
    {
        string a;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            a = TextBox1.Text;
            Response.Write("<script>alert(a)</script>");

        }
    }
}