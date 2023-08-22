using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace basicnew
{
    public partial class encapsulation2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        class encap
        {
            private string studentName;
            private int studentAge;
          
            public string Name
            {
                get { return studentName; }

                set { studentName = value; }
            }      
            public int Age
            {

                get { return studentAge; }

                set { studentAge = value; }
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
           encap obj = new encap();
            obj.Name = "arun";
            obj.Age = 21;
            TextBox1.Text= obj.Name;
            TextBox2.Text = obj.Age.ToString();
        }
    }
}