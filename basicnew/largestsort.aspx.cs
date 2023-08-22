using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace basicnew
{
    public partial class largestsort : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //    int n;
            //    int[] arr1 = { 2, 5, 67, 3, 8 };
            //    // storing the largest number to arr[0]
            //    for (int i = 1; i < arr1.Length; ++i)
            //    {
            //        if (arr1[0] < arr1[i])
            //        {
            //            arr1[0] = arr1[i];
            //        }
            //    }
            //    TextBox1.Text = arr1[0].ToString();

            //}

            string[] temp_str = new string[] { "1000", "2000", "3000" };
            int[] temp_int = Array.ConvertAll(temp_str, s => int.Parse(s));
            int[] temp_int1 = temp_str.Select(int.Parse).ToArray();
            for (int i = 0; i < temp_int.Length; i++)
            {
                TextBox1.Text = temp_int[i].ToString();
            }
        }
    }
}