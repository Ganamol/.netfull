using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace basicnew
{
    public partial class polymorphisam : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        class Animal  
        {
            public virtual  string read()
            {
                return "animal";
            }
        }

        class Pig : Animal  
        {
            public override  string read()
            {
                return "pig";
            }
        }

        class Dog : Animal 
        {
            public override string read()
            {
                return "dog";
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Animal A= new Animal(); 
            Pig P = new Pig();  
            Dog d = new Dog();  

            TextBox1.Text = A.read();
            TextBox2.Text = P.read();
            TextBox3.Text = d.read();
        }
    }
}