using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace basicnew
{
    public partial class SWITCH1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ch;
            ch = TextBox1.Text;

            switch (ch)
            {
                case "a":
                    TextBox2.Text = "Vowel";
                    break;
                case "e":
                    TextBox2.Text = "Vowel";
                    break;
                case "i":
                    TextBox2.Text = "Vowel";
                    break;
                case "o":
                    TextBox2.Text = "Vowel";
                    break;
                case "u":
                    TextBox2.Text = "Vowel";
                    break;
                default:
                    TextBox2.Text = "Not a Vowel";
                    break;

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
           int c;
            c =Convert.ToInt32(TextBox1.Text);

            switch (c)
            {
                case 0:
                    TextBox2.Text = "sunday";
                    break;
                case 1:
                    TextBox2.Text = "monday";
                    break;
                case 2:
                    TextBox2.Text = "Tuesday";
                    break;
                case 3:
                    TextBox2.Text = "Wednesday";
                    break;
                case 4:
                    TextBox2.Text = "Thursday";
                    break;
                case 5:
                    TextBox2.Text = "Friday";
                    break;
                default:
                    TextBox2.Text = "not in a week";
                    break;

            }

        }
    }
}