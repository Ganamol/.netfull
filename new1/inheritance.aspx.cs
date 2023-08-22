using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace new1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



            public class Employee
            {
                public float salary = 40000;
            }
            public class Programmer : Employee
            {
                public float bonus = 10000;
            }
        public class developer : Programmer
        {
            public float total = 25000;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //  developer p1 = new developer();
            //TextBox1.Text = p1.salary.ToString();
            //TextBox2.Text = p1.bonus.ToString();
            //TextBox3.Text = p1.total.ToString();
            developer p = new developer();
            TextBox1.Text = p.salary.ToString();
            TextBox2.Text = p.bonus.ToString();
            TextBox3.Text = p.total.ToString();

        }
    }
}
    
