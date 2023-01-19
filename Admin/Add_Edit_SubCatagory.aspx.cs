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
    public partial class Add_Edit_SubCatagory : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["con"].ConnectionString);
        SqlCommand cmd;
        SqlDataAdapter adp;
        SqlDataReader dr;
        DataTable dt = new DataTable();
        string query;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                query = "select Cat_id,Catagory_name from Catagory";
                cmd = new SqlCommand(query, con);
                adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                DropDownList1.DataSource = dt;
                DropDownList1.DataTextField = "Catagory_name";
                DropDownList1.DataValueField = "Cat_id";
                DropDownList1.DataBind();
                DropDownList1.Items.Insert(0, new ListItem("select", "0"));
            }
        }
        public void Bind()
        {
            DropDownList1.DataSource = dt;
            DropDownList1.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            query = "select Subcat_Name from Sub_Catagory where Subcat_Name =@Subcat_Name";
            cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Subcat_Name", txtSub.Text.Trim());
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Literal1.Text = "Record Is Duplicate";
                txtSub.Text = "";
            }
            else
            {
                query = "_Sub_Catagory";
                cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cat_id", DropDownList1.SelectedValue);
                cmd.Parameters.AddWithValue("@Subcat_Name", txtSub.Text.Trim());
                cmd.Parameters.AddWithValue("@Admin_Eamil", Session["username"].ToString());

                con.Open();
                cmd.ExecuteNonQuery();
                Literal1.Text = "Record Is Inserted";
                txtSub.Text = "";


            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            Bind();
        }
    }
}