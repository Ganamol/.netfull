using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace basicnew
{
    public partial class hierarchical_inheritance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        class animal
        {
            public string color, name;
        }
        class bird : animal
        {
            public string display()
            {
                color = "black";
                return "color" + color;
            }
        }
        class fly : animal
        {
            public string details()
            {
                name = "crow";
                return " bird is" + name;

            }
        }
    
        protected void Button1_Click(object sender, EventArgs e)
        {
            fly f = new fly();
            bird b = new bird();
            TextBox1.Text = b.display();
            TextBox2.Text = f.details();
        }
    }
}