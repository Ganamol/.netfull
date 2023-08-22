using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace new1
{
    public partial class first : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Add("apple");
            ListBox1.Items.Add("orange");
            ListBox1.Items.Add("pine");
            ListBox1.Items.Add("cashew");

            DropDownList1.Items.Add("1");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Webform1.aspx");
        }

        protected void CheckBoxList1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}