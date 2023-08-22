using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace firstfirst
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        class Car
        {
            public string model;


            public Car()
            {
                model = "celerio";
            }


        }

        //class Car
        //{
        //    public string model;


        //    public Car(string modelName)
        //    {
        //        model = modelName;
        //    }


        //}
        //class Car
        //{
        //    public string model;
        //    public string color;
        //    public int year;

        //    // Create a class constructor with multiple parameters
        //    public Car(string modelName, string modelColor, int modelYear)
        //    {
        //        model = modelName;
        //        color = modelColor;
        //        year = modelYear;
        //    }
        //}

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Car Ford = new Car();
            //TextBox1.Text = Ford.model.ToString();
            //    Car Ford = new Car("celerio");
            //    TextBox1.Text = Ford.model.ToString();

            //Car Ford = new Car("Mustang", "Red", 1969);
            //TextBox1.Text = Ford.color + " " + Ford.year + " " + Ford.model;
        }
    }
}