using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace basicnew
{
    public partial class splitstring : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        string arr;
        int sum;
        protected void Button1_Click(object sender, EventArgs e)
        {
            String str = TextBox1.Text;

            String[] spearator = { ",", " " };
      
            String[] arr = str.Split(spearator, 2,
                   StringSplitOptions.RemoveEmptyEntries);
          
            int  j;
            for (j = 0; j < arr.Length; j++)
            {
                sum +=Convert.ToInt32(arr[j]);

            }
            TextBox1.Text = sum.ToString();


        }
    }
}