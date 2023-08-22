using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace firstproject12
{
    public partial class second : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           if(!IsPostBack)
            {

            }

        }
        public int a;
        protected void Button1_Click(object sender, EventArgs e)
        {
            a =Convert.ToInt32( Button1.Text);
            TextBox1.Text = a.ToString() ;
        }
       public int b;
        protected void Button2_Click(object sender, EventArgs e)
        {
            b = Convert.ToInt32(Button1.Text);
            TextBox1.Text = b.ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "+".ToString();
        }
        int c;
        protected void Button5_Click(object sender, EventArgs e)
        {
            c = a + b;
            TextBox1.Text = c.ToString();
        }
        //public int d;
        protected void Button6_Click(object sender, EventArgs e)
        {
            //TextBox1.Text = d.ToString();

        }
    }
}