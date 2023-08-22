using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace basicnew
{
    public partial class sort : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int i;
            string[] arr = new string[5] { "A","D", "Z", "G", "M" };
            for (i = 0; i < arr.Length; i++)
            {
                //ListBox1.Items.Add(arr[i].ToString());

                if (arr[i] == "V")
                {
                    TextBox1.Text = "element in array";
                    break;
                }
                else
                {
                    TextBox1.Text = "element not in array";
                }

            }


            //int[] arr1 = { 2, 5, 67, 3, 8 };
            //for (int j = 0; j < arr1.Length; j++)
            //{
            //    ListBox2.Items.Add(arr1[j].ToString());

            //}
            // int[] arr2 = { 22, 15, 17, 33, 8 };
            //foreach (int a2 in arr2)
            //{
            //    ListBox3.Items.Add(a2.ToString());

            //}









            //foreach (string g in arr)
            //{
            //    if (g == "Y")
            //    {
            //        TextBox1.Text = "element in array";
            //        break;
            //    }
            //    else
            //    {
            //        TextBox1.Text = "element not in array";

            //    }
            //}
            //string c = TextBox1.Text;
            //foreach (string g in arr)
            //{
            //    if (g == c)
            //    {
            //        TextBox2.Text = "Present";
            //        break;
            //    }
            //    else
            //    {
            //        TextBox2.Text = "Not Present";

            //    }
            //}


        }

    }
    }
