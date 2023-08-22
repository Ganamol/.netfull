using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace WebApplication37
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOPLAB-15888\SQLEXPRESS;Initial Catalog=school_db;Integrated Security=True");

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO student_reg(s_name, s_age, email, phone, password) VALUES('"+TXT_NAME.Text+"','"+TXT_AGE.Text+"', '"+TXT_email.Text + "', '"+ TXT_PHONE.Text + "', '"+TXT_PASSWORD.Text+"')",con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}