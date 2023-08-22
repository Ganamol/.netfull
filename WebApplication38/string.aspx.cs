using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication38
{
    public partial class _string : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string text = "Hello";
            TextBox1.Text = text.Length.ToString();
            TextBox1.Text = text.ToLower().ToString();

            TextBox1.Text = text.ToUpper().ToString();





            string firstName = "John ";
            string lastName = "Doe";
            string name = firstName + lastName;
            TextBox1.Text = name.ToString();


            string fName = "John";
            string lName = "Doe";
            string name1 = $"My full name is: {fName} {lName}";
            TextBox1.Text = name1.ToString();

        }
    }
}