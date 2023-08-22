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
    public partial class select : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOPLAB-15888\SQLEXPRESS;Initial Catalog=login_db;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                //Grid();
                
                con.Open();
              //  string user = Session["usermail"].ToString();
                SqlCommand cmd = new SqlCommand("select * from register_tb", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
            }
        }
        int r_id;
        


        protected void Button1_Click1(object sender, EventArgs e)
        {
            //string gen1;
            //if (RadioButton1.Checked == true)
            //{
            //    gen1 = "Male";

            //}
            //else
            //{
            //    gen1 = "Female";

            //    SqlCommand cmd = new SqlCommand("update register_tb set fname='" + fname.Text + "',lname='" + lname.Text + "',email='" + email.Text + "',gender='" + gen1 + "',phone = '" + phone.Text + "',pwd='" + password.Text + "' where r_id='" + id.Text + "'", con);
            //    SqlDataAdapter da = new SqlDataAdapter(cmd);
            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //    con.Close();

            //    //fname.Text = "";
            //    //id.Text = "";
            //    //lname.Text = "";
            //    //email.Text = "";
            //    //phone.Text = "";
            //    //RadioButton1.Checked = false;
            //    //RadioButton2.Checked = false;
            //    //password.Text = "";


            //}
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            r_id = Convert.ToInt32((sender as Button).CommandArgument);
            Session["rid"] = r_id;
            Response.Redirect("registration.aspx");

            SqlCommand cmd = new SqlCommand("select * from register_tb where r_id='" + r_id + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            string gen;
            if (dt.Rows.Count > 0)
            {
                //id.Text = dt.Rows[0][0].ToString();
                //fname.Text = dt.Rows[0][1].ToString();
                //lname.Text = dt.Rows[0][2].ToString();
                //email.Text = dt.Rows[0][3].ToString();
                //gen = dt.Rows[0][4].ToString();
                //if (gen == "Male")
                //{
                //    RadioButton1.Checked = true;
                //}
                //else
                //{
                //    RadioButton2.Checked = true;
                //}
                //phone.Text = dt.Rows[0][5].ToString();
                //password.Text = dt.Rows[0][6].ToString();

            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            r_id = Convert.ToInt32((sender as Button).CommandArgument);
            Session["rid"] = r_id;
            Response.Redirect("registration.aspx");
            SqlCommand cmd = new SqlCommand("select * from register_tb where r_id='" + r_id + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            string gen;
            if (dt.Rows.Count > 0)
            {
                //id.Text = dt.Rows[0][0].ToString();
                //fname.Text = dt.Rows[0][1].ToString();
                //lname.Text = dt.Rows[0][2].ToString();
                //email.Text = dt.Rows[0][3].ToString();
                //gen = dt.Rows[0][4].ToString();
                //if (gen == "Male")
                //{
                //    RadioButton1.Checked = true;
                //}
                //else
                //{
                //    RadioButton2.Checked = true;
                //}
                //phone.Text = dt.Rows[0][5].ToString();
                //password.Text = dt.Rows[0][6].ToString();
                //Button1.Text = "DELETE";

            }

        }
    }
}