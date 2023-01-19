using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace E_commerce.Admin
{
    public partial class AdminMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"]!=null)
            {

                Literal1.Text= Session["username"].ToString();
            }
            else
            {
                Response.Redirect("../AdminLogin.aspx");
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            var EmailintoBytes = Encoding.UTF8.GetBytes(Literal1.Text);
            var EncodedEmail = Convert.ToBase64String(EmailintoBytes);

            string url;
            url = "Editprofile.aspx?e=" + EncodedEmail;
            Response.Redirect(url);
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Session.Clear();
            Response.Redirect("../AdminLogin.aspx");
        }
    }
}