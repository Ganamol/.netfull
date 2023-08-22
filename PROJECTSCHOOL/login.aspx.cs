using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROJECTSCHOOL
{
    public partial class login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOPLAB-15888\SQLEXPRESS;Initial Catalog=login_db;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();

            if (TextBox1.Text == "admin" && TextBox2.Text == "admin")
            {
                Response.Redirect("adminhome.aspx");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("select * from log_tb where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Session["usermail"] = dt.Rows[0][1].ToString();
                    Response.Redirect("userhome.aspx");

                }


            }
        }
    }
}
