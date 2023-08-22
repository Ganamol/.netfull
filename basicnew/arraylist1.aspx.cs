using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace basicnew
{
    public partial class arraylist1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //ArrayList My_array = new ArrayList();


            //My_array.Add(1);
            //My_array.Add("z");
            //My_array.Add(8);
            //My_array.Add("E");
            //My_array.Add("M");

            //foreach (var elements in My_array)
            //{
            //    ListBox1.Items.Add(elements.ToString());
            //}


            //My_array.Sort();

            //foreach (var elements in My_array)
            //{

            //    ListBox2.Items.Add(elements.ToString());
            //}
            // TextBox1.Text = My_array.Count.ToString();

            // TextBox1.Text = My_array.Count.ToString();


            List<int> firstlist = new List<int>();

            firstlist.Add(1);
            firstlist.Add(2);
            firstlist.Add(3);
            firstlist.Add(4);
            List<int> firstlist1 = new List<int>();
            foreach (var elements in firstlist)
            {

                ListBox1.Items.Add(elements.ToString());
            }
            firstlist1.Add(1);
            firstlist1.Add(2);
            firstlist1.Add(3);
            firstlist1.Add(4);
            firstlist.Sort();
            foreach (var elements1 in firstlist1)
            {

                ListBox2.Items.Add(elements1.ToString());

            }
            if (firstlist.SequenceEqual(firstlist1))
            {
                TextBox1.Text = "equal";
            }
            else
            {
                TextBox1.Text = "not equal";
            }

        }
    }
}