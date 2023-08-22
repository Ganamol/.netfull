using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace firstnew
{
    public partial class radio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {

            }
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        string ch;
        protected void Button1_Click(object sender, EventArgs e)
        {
            if(CheckBox1.Checked==true)
            {
                ListBox1.Items.Add("sslc");
            }
          if(CheckBox2.Checked==true)
            {
                ListBox1.Items.Clear();
                ListBox1.Items.Add("plus two");
            }
            if (CheckBox3.Checked == true)
            {
                ListBox1.Items.Clear();
                ListBox1.Items.Add("degree");
            }
           

        }

        protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("webForm1.aspx");
        }
    }
}