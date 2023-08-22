using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace basicnew
{
    public partial class abstractclass1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        abstract class Animal
        {
            
            public abstract string Sound();
            string name;
            public string bird()
            {
                return name = "crow";
            }
        }

        
        class crow : Animal
        {
            public override string Sound()
            {
                return "ka ka";
            }
        }

        //sealed class A
        //{

        //}
        //class B:A
        //{

        //}
        protected void Button1_Click(object sender, EventArgs e)
        {
            crow c = new crow();
            TextBox2.Text = c.bird();
            TextBox1.Text= c.Sound();
            
        }
    }
}