using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace new1
{
    public partial class _while : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < 5)
            {
                ListBox1.Items.Add(i.ToString());
                i++;
            }








            int i = 0;
            do
            {
                ListBox1.Items.Add(i.ToString());
                i++;
            }
            while (i < 5);
        }
    }
}