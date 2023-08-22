using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace firstfirst
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        class Vehicle   
        {
            public string brand = "Ford";  
            public string display()            
            {
                return "new car";
            }
        }

        class bus : Vehicle  
        {
            public string modelName = "Mustang";  
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            bus myCar = new bus();


            TextBox1.Text = myCar.display();
            TextBox2.Text = myCar.brand + "....." + myCar.modelName;
         
        }
    }
}