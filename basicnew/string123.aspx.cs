using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace basicnew
{
    public partial class string123 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //TextBox1.Text = txt.Trim.ToString();

            //string txt1 = "Hello World";
            //txt1.ToUpper();
            //txt1.ToLower();

            //string firstName = "Anu";
            //string lastName = "K";

            //string name = firstName + lastName;
            //TextBox1.Text = string.Concat(firstName, lastName);

            //string myString = "Hello";
            //TextBox1.Text = myString[0].ToString();

            string text = "    Ice cream   ";
            string s1 = text.Trim();
            string s2 = text.TrimStart();
            string s3 = text.TrimEnd();
            TextBox1.Text = s1.ToString();

           TextBox1.Text=  Math.Max(5, 10).ToString();

            int a;
            a = Math.Min(5, 10);
            TextBox1.Text = a.ToString();

            double b,c,d;
            b = Math.Sqrt(64);
            TextBox1.Text = b.ToString();

            c = Math.Abs(-4.7);
            TextBox1.Text = c.ToString();
            d = Math.Round(9.99);
            TextBox1.Text = d.ToString();
            
        }
    }
}