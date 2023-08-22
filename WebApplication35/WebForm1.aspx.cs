using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication35
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
      

        protected void Button2_Click(object sender, EventArgs e)
        {
           
        }

      

        protected void Button2_Click1(object sender, EventArgs e)
        {
            Class1 c = new Class1();
          TextBox3.Text=  c.mul().ToString();
        }

        int d;
        protected void Button1_Click(object sender, EventArgs e)
        {
            string c;
            string[] arr = new string[5];//creating array  
            arr[0] = "10";//initializing array  
            arr[2] = "20";
            arr[4] = "30";

            //traversing array  
          foreach(string arr1 in arr)
            {
                TextBox1.Text = TextBox1.Text+ Environment.NewLine + arr1;
            }


            //TextBox1.Text = Calendar1.SelectedDate.ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string a, b, c;
            a = "ahjbhgvg";
            b = "bcccc";

            TextBox1.Text = string.Compare(a, b).ToString();
        }
    }
}