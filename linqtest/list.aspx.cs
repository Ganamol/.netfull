using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace linqtest
{
    public partial class list : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            List<int> primeNumbers = new List<int>();

            primeNumbers.Add(1);
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);

            var query = from n in primeNumbers select n;

            foreach (var w in query)
            {
                ListBox1.Items.Add(w.ToString());
            }




            //var cities = new List<string>();
            //cities.Add("New York");
            //cities.Add("London");
            //cities.Add("Mumbai");
            //cities.Add("Chicago");
            
            //foreach (var w in cities)
            //{
            //    ListBox1.Items.Add(w.ToString());
            //}


        }
    }
}