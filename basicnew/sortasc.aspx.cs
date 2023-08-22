using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace basicnew
{
    public partial class sortasc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        int sum;
        protected void Button1_Click(object sender, EventArgs e)
        {
            //int[] n = new int[10];
            //int i, j;


            //for (i = 0; i < 10; i++)
            //{
            //    n[i] = i + 100;
            //}


            //for (j = 0; j < 10; j++)
            //{
            //    sum += n[j];

            //}
            //ListBox1.Items.Add(sum.ToString());


            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };

            foreach (int i in numbers)
            {
                ListBox1.Items.Add(i.ToString());
            }
        }
    }
}