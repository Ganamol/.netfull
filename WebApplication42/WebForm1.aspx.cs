using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication42
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //int c = i * 2;
            //ListBox1.Items.Add(i+"*"+"2"+"="+c.ToString());
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num = 1556;
                int result = 0;
                while (num > 0)
                {
                    result = result * 10 + num % 10;
                    num /= 10;
                }
                ListBox1.Items.Add(result.ToString());
           
            
        }
    }
}