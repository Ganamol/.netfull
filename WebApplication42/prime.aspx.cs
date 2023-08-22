using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication42
{
    public partial class prime : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(TextBox1.Text);
            if(a%2==0)
            {
                TextBox2.Text = "even";
            }
            else
            {
                TextBox2.Text = "odd";
            }
        }

    }
}