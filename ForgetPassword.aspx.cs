using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Net.Mail;

namespace E_commerce
{
    public partial class ForgetPassword : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["con"].ConnectionString);
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt = new DataTable();
        string query;
        string url;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                query = "Select Admin_Passwod from Admin_User where Admin_Email=@Admin_Email";
                cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Admin_Email", txtEmail.Text.Trim());
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    //Literal1.Text = "YOUR CURRENT PASSWORD IS:  " + dr["Admin_Passwod"].ToString();
                    // Response.Redirect("http://localhost:53190/ChangePassword.aspx?email=" +name);
                    // http://localhost:53190/ChangePassword.aspx?email=sachin@gmail.com
                    Success.Visible= true;
                    mail();
                }
                else
                {
                    Alert.Visible = true;
                    txtEmail.Text = "";
                }
            }
            finally
            {
                con.Close();
            }
        }
        
        private void mail()
        {
            string name = txtEmail.Text.Trim();
            url = "http://localhost:53190/ChangePassword.aspx?email" + name;
            string to = "sachin.kumarbihar246@gmail.com"; //to address    
            string from = "logancsjmu@gmail.com"; //from address    
            MailMessage message = new MailMessage(from, to);

            string mailbody = "YOUR <b> Current PASSWORD</b> IS :" + dr["Admin_Passwod"].ToString() + "<br>" +url.ToString() ;
            message.Subject = "PAssword Recovery";
            message.Body = mailbody;
            message.BodyEncoding = System.Text.Encoding.UTF8;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
            System.Net.NetworkCredential basicCredential1 = new
            System.Net.NetworkCredential("sachin.kumarbihar246@gmail.com", "zzqeykhupytoslbz");
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = basicCredential1;
            try
            {
                client.Send(message);
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}