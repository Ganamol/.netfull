using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace new1
{
    public partial class array : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //int[] arr = new int[5] { 10, 20, 30, 40, 50 };
        //int[] arr = new int[] { 10, 20, 30, 40, 50 };
        //int[] arr = { 10, 20, 30, 40, 50 };

        protected void Button1_Click(object sender, EventArgs e)
        {

            //int[] arr = new int[5];
            //arr[0] = 10;
            //arr[1] = 20;
            //arr[2] = 30;
            //arr[3] = 30;
            //arr[4] = 30;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    ListBox1.Items.Add(arr[i].ToString());
            //}








            //int[] arr = { 10, 20, 30, 40, 50 };


            //foreach (int i in arr)
            //{
            //    ListBox1.Items.Add(i.ToString());
            //}







            int[,] arr1 = new int[3, 3];
            arr1[0, 0] = 5;
            arr1[0, 1] = 10;
            arr1[1, 2] = 20;
            arr1[2, 0] = 30;

            string a = "";
            for (int i = 0; i < 3; i++)
            {
                a = "";
                for (int j = 0; j < 3; j++)
                {
                    a += arr1[i, j];

                }
                ListBox1.Items.Add(a.ToString());
            }
        }
    }
}