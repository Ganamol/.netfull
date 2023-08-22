using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace PROJECTSCHOOL
{
    public partial class registration : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOPLAB-15888\SQLEXPRESS;Initial Catalog=login_db;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {

            }
        }
      public void clear()
        {
            fname.Text = "";
            lname.Text = "";
            RadioButton1.Checked = false;
            
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string r_id = Session["rid"].ToString();
            SqlCommand cmd = new SqlCommand("select * from register_tb where r_id='" + r_id + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            string gen;
            if (dt.Rows.Count > 0)
            {
               // id.Text = dt.Rows[0][0].ToString();
                fname.Text = dt.Rows[0][1].ToString();
                lname.Text = dt.Rows[0][2].ToString();
                email.Text = dt.Rows[0][3].ToString();
                gen = dt.Rows[0][4].ToString();
                if (gen == "Male")
                {
                    RadioButton1.Checked = true;
                }
                else
                {
                    RadioButton2.Checked = true;
                }
                phone.Text = dt.Rows[0][5].ToString();
                password.Text = dt.Rows[0][6].ToString();
            }
              //  string gen;
            //con.Open();
            //SqlCommand cmd = new SqlCommand("spregister", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@fname", fname.Text);
            //cmd.Parameters.AddWithValue("@lname", lname.Text);
            //cmd.Parameters.AddWithValue("@email", email.Text);
            //if (RadioButton1.Checked == true)
            //{
            //    gen = "male";
            //}
            //else
            //{
            //    gen = "female";
            //}
            //cmd.Parameters.AddWithValue("@gender", gen);
            //cmd.Parameters.AddWithValue("@phone", phone.Text);
            //cmd.Parameters.AddWithValue("@pwd", password.Text);
            //cmd.ExecuteNonQuery();
            //con.Close();
        }

        protected void email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}