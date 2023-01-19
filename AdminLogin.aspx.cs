using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace E_commerce.Admin
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["con"].ConnectionString);
        SqlCommand cmd;
        SqlDataAdapter adp;
        SqlDataReader dr;
        DataTable dt = new DataTable();
        string query;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                query = "Select Count(*) from Admin_User where Admin_Email=@Admin_Email and Admin_Passwod=@Admin_Passwod";
                cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Admin_Email",txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@Admin_Passwod",txtPass.Text.Trim());
                con.Open();
                int i = (int)cmd.ExecuteScalar();
                if(i==1)
                {
                    Session["username"] = txtEmail.Text;
                    Response.Redirect("Admin/Dashboard.aspx");
                }
                else
                {
                  Alert.Visible= true;
                }
            }
            catch(Exception ex)
            {
                throw(ex);
            }
            finally
            {
                con.Close();
            }
        }
    }
}