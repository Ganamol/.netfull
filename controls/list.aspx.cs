using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace controls
{
    public partial class list : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        int i = 1;
        protected void Button1_Click1(object sender, EventArgs e)
        {
            
            for (i=1;i<=10;i++)
            {
                ListBox1.Items.Add(i.i*2.ToString());
            }
            
        }
    }
}