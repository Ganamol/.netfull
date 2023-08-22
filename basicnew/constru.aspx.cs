using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace basicnew
{
    public partial class constru : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //public class Car
        //{

        //    string model;
        //    public Car()
        //    {

        //    }

        //}
        //public class Car
        //{

        //    public string brand;
        //    public int price;


        //    public Car(string theBrand, int thePrice)
        //    {

        //        brand = theBrand;
        //        price = thePrice;
        //    }

        //}

        //Copy constructors are the member functions of a class that initialize the data members of the class using another object of the same class. It copies the values of the data variables of one object of a class to the data members of another object of the same class.
        class Student
        {
            private string name;
            private int rank;

            public Student(Student s)
            {
                name = s.name;
                rank = s.rank;
            }

            public Student(string name, int rank)
            {
                this.name = name;
                this.rank = rank;
            }

            public string Display
            {
                get
                {

                    return " Student " + name + " got Rank " + rank.ToString();
                }
            }
        }




        protected void Button1_Click(object sender, EventArgs e)
        {
            //Car c = new Car();

            //Car c = new Car("i10", 220000);
            //TextBox1.Text = c.brand.ToString();
            //TextBox2.Text = c.price.ToString();

            Student s1 = new Student("Maya", 2);
            Student s2 = new Student(s1);
            TextBox1.Text = s2.Display;










        }
    }
}