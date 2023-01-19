using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace E_commerce
{
    public partial class CreatePassword : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["con"].ConnectionString);
        SqlCommand cmd;
        DataTable dt = new DataTable();
        string query;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["Email"] != null)
            {
                txtEmail.Text= Request.QueryString["Email"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Name = txtEmail.Text.Trim();
            string Pass = txtPass.Text.Trim();
            query = "update Admin_User set Admin_Passwod=@Pass where Admin_Email=@Email";
            cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Email", Name);
            cmd.Parameters.AddWithValue("@Pass", Pass);
            con.Open();
            int i = (int)cmd.ExecuteNonQuery();
            if (i == 1)
            {
                Success.Visible = true;
            }
            else
            {
               Alert.Visible = true;
            }
            txtEmail.Text = "";
            txtPass.Text = "";
        }
    }
}