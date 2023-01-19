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
    public partial class RegistrationFrom : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["con"].ConnectionString);
        SqlCommand cmd;
        SqlDataAdapter adp;
        DataTable dt = new DataTable();
        string query;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Register_Click(object sender, EventArgs e)
        {
            string session = String.Empty;
            string gender = string.Empty;
            if(male.Checked)
            {
                gender = "Male";
            }
            else if(female.Checked)
            {
                gender = "Female";
            }
            string Pic = Guid.NewGuid().ToString() + FileUpload1.FileName;
            FileUpload1.SaveAs(Request.PhysicalApplicationPath + "//Upload//" + Pic);
            query = "_Admin_User_Insert";
            cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@First_Name",txtFirst.Text.Trim());
            cmd.Parameters.AddWithValue("@Last_Name", txtLast.Text.Trim());
            cmd.Parameters.AddWithValue("@Gender", gender);
            cmd.Parameters.AddWithValue("@Admin_Email", txtEmail.Text.Trim());
            cmd.Parameters.AddWithValue("@Mobile_No", txtMobile.Text.Trim());
            cmd.Parameters.AddWithValue("@Admin_Passwod", txtPassword.Text.Trim());
            cmd.Parameters.AddWithValue("@Session_Id", session);
            cmd.Parameters.AddWithValue("@Pic", Pic);
            adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            Response.Write(" Registration Successful");
        }
    }
}