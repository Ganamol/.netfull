using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace firstnew
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        int a = DateTime.Today;
        string display;
        protected void Button1_Click(object sender, EventArgs e)
        {

           switch(a)
            {
                case 2:
                    display = "2";
                    break;
                case 3:
                    display = "3";
                    break;
                case 4:
                    display = "4";
                    break;
                default:
                    display = "none";
                    break;
            }
            TextBox1.Text = display;
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}