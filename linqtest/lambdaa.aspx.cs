using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace linqtest
{
    public partial class lambdaa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Func<int, int, int,int> add1 = (x, y,z) => x + y+z;
        class property
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            //TextBox1.Text = add1(24,34,23).ToString();

            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };

            //List<int> evenNumbers = list.FindAll(x => (x % 2) == 0);

            //foreach (var num in evenNumbers)
            //{
            //    ListBox1.Items.Add(num.ToString());
            //}

        
        List<property> n = new List<property>() {
            new property { Name = "Ayan", Age = 4 },
            new property { Name = "Alan", Age = 0 },
            new property { Name = "Anu", Age = 3 }
         };
            var names = n.Select(x => x.Name);
            foreach (var name in names)
            {
                ListBox1.Items.Add(name.ToString());

            }

        }
    }
}