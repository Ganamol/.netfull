using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace basicnew
{
    public partial class abstractclass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        


        abstract class Shape
        {
            public abstract int area();
        }
        class Square : Shape
        {

            private int side;

            public Square(int x)
            {
                side = x;
            }
            public override int area()
            {
                return (side * side);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Square sh = new Square(4);

            
            double result = sh.area();

           TextBox1.Text= result.ToString();
        }
    }
}