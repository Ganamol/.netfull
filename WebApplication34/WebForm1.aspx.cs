using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication34
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        string a;
        protected void Button1_Click(object sender, EventArgs e)
        {
            //string[] name = new string[] { "anju", "binu" };



            //int[] marks = new int[] { 99, 98, 92, 97, 95 };

            //for (int i=0;i<name.Length;i++)
            //{
            //    ListBox1.Items.Add(name[i]);

            //}
            //foreach(var m in marks)
            //{
            //    ListBox2.Items.Add(m.ToString());
            //}
            // Sort a string
            string[] cars = { "V", "B", "F", "M" };
            Array.Sort(cars);
            foreach (string i in cars)
            {
                ListBox1.Items.Add(i);
            }

            // Sort an int
            int[] myNumbers = { 5, 1, 8, 9 };
           
            Array.Reverse(myNumbers);
            foreach (int i in myNumbers)
            {
                ListBox2.Items.Add(i.ToString());
            }
        }
    }
}