using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace basicnew
{
    public partial class multiple : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        interface IShape
        {
            double GetArea();
        }

        interface IColor
        {
            string GetColor();
        }

        class Rectangle : IShape, IColor
        {
            private double length;
            private double breadth;
            private string color;

            public Rectangle(double length, double breadth, string color)
            {
                this.length = length;
                this.breadth = breadth;
                this.color = color;
            }

            public double GetArea()
            {
                return length * breadth;
            }

            public string GetColor()
            {
                return color;
            }
        }
       
        protected void Button1_Click(object sender, EventArgs e)
        {

            Rectangle rect = new Rectangle(5, 10, "blue");
            TextBox1.Text="Area of rectangle: " + rect.GetArea();
            TextBox2.Text = "Color of rectangle: " + rect.GetColor();
        }
    }
}