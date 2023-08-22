using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace errorhandling
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int[] Array1 = new int[5] { 1, 2, 3, 4, 5 };
                for(int i=0;i<Array1.Length+1;i++)
                {
                    TextBox1.Text = Array1[i].ToString();
                }
            }
            catch(Exception e1)
            {
                //TextBox1.Text = e1.ToString();
               
                

            }
            finally
            {

            }
        }
    }
}