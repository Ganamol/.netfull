﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace basicnew
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
      
        protected void Button1_Click(object sender, EventArgs e)
        {
            add a = new add();
            int d = Convert.ToInt32(TextBox1.Text);
           

            
           
            TextBox1.Text = a.add1(d).ToString();
        }

    }
    }
    
    