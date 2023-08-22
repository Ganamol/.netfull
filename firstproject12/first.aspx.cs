using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace firstproject12
{
    public partial class first : System.Web.UI.Page
    {
         public static int i = 1, j = 1, k = 1;
         public  static string a,b,c,d;
        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList1.Items.Add("select");
            for (i = 1; i <= 30; i++)
            {

                DropDownList1.Items.Add(i.ToString()); ;

            }
            DropDownList2.Items.Add("select");
            for (j = 1; j <= 12; j++)
            {

                DropDownList2.Items.Add(j.ToString()); ;

            }
            DropDownList3.Items.Add("select");
            for (k = 1999; k <= 2023; k++)
            {

                DropDownList3.Items.Add(k.ToString()); ;

            }
        }

        protected void btn1_Click(object sender, EventArgs e)
        {

        }
      
        protected void Button1_Click(object sender, EventArgs e)
        {
             a = DropDownList1.SelectedValue;
            b = DropDownList2.SelectedValue;
             c = DropDownList3.SelectedValue;
           d = a+ "/"+ b+"/" + c;
            TextBox1.Text = d.ToString();
        }
    }
}