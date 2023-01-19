using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Text;

namespace E_commerce.Admin
{
    public partial class EditProfile : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["con"].ConnectionString);
        SqlCommand cmd;
        DataTable dt = new DataTable();
        string query;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["e"] != null)
                {
                    var EmailIDintoBytes = Convert.FromBase64String(Request.QueryString["e"]);
                    var EncodedEmail = Encoding.UTF8.GetString(EmailIDintoBytes);
                    txtEmail.Text = EncodedEmail.ToString();
                    // txtmail.Text = RequestRequest.QueryString["Email"].ToString();

                    cmd = new SqlCommand("select* from Admin_user where Admin_Email=@Admin_Email", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Admin_Email", txtEmail.Text.Trim());
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {

                        Image1.ImageUrl = "../Upload/" + dr["Pic"];
                        txtEmail.Text = dr["Admin_Email"].ToString();
                        txtfname.Text = dr["First_Name"].ToString();
                        txtlname.Text = dr["Last_Name"].ToString();
                        string gender = dr["Gender"].ToString();
                        txtpass.Text = dr["Admin_Passwod"].ToString();
                        txtmob.Text = dr["Mobile_No"].ToString();
                    }
                    con.Close();
                }
            }

        }

        protected void bt_profile_Click(object sender, EventArgs e)
        {
            string gender = string.Empty;
            if (male.Checked)
            {
                gender = "Male";
            }
            else if (female.Checked)
            {
                gender = "Female";
            }
            FileUpload1.SaveAs(Request.PhysicalApplicationPath + "//Upload//" + FileUpload1.FileName);
            query = "_update_Admin_User";
            cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Admin_Email",txtEmail.Text.Trim());
            cmd.Parameters.AddWithValue("@First_name", txtfname.Text.Trim());
            cmd.Parameters.AddWithValue("@Last_name", txtlname.Text.Trim());
            cmd.Parameters.AddWithValue("@Gender", gender);
            cmd.Parameters.AddWithValue("@Mobile_No", txtmob.Text.Trim());
            cmd.Parameters.AddWithValue("@Admin_Passwod", txtpass.Text.Trim());
            cmd.Parameters.AddWithValue("@Pic", FileUpload1.FileName);
            Image1.ImageUrl = "../Upload/" + FileUpload1.FileName;
            con.Open();
            int i = (int)cmd.ExecuteNonQuery();
            if (i == 1)
            {
                Label1.Visible = true;
            }
            else
            {
                Response.Write("TRY AGAIN");
            }
        }
    }
}