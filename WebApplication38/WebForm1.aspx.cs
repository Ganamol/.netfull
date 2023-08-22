using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication38
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //int[] n = new int[10]; 
            //int i;


            //for (i = 0; i < 10; i++)
            //{
            //    n[i] = i + 100;
            //    ListBox1.Items.Add(n[i].ToString());
            //}

            string[] fruits = { "Apple", "Banana", "Papaya", "Grapes" };

            foreach (string f1 in fruits)
            {
                ListBox1.Items.Add(f1);
            }

        }
    }
}