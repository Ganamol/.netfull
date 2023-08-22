using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication20
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        int  a,b,temp;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            /* a=Convert.ToInt32(TextBox1.Text);
              b = Convert.ToInt32(TextBox2.Text);
              /* temp = a;
               a = b;
               b = temp;
               TextBox3.Text = a.ToString();
               TextBox4.Text = b.ToString();*/


            /* if(a>b)
             {
                 temp = a;
             }
             else
             {
                 temp = b;
             }
             TextBox3.Text = temp.ToString();
            */

            /* for(int i=0;i<5;i++)
             {
                 Label1.Text = Label1.Text + i;


             }*/

            int[] arr = new int[3];//creating array  
            arr[0] = 10;//initializing array  
            arr[1] = 20;
            arr[2] = 30;

            //traversing array  
            for (int i = 0; i < arr.Length; i++)
            {
                ListBox1.Items.Add(arr[i].ToString());
              
            }

        }
    }
}