using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication35
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }
        string err;
        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "";
            if(RadioButton1.Checked==false)
            {
               Label1.Text = "error";
            }
            else if(RadioButton2.Checked==false)
            {
                err = "error";
            }
            err = "error";
        }
    }
}