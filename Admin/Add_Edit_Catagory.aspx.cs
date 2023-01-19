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
    public partial class Add_Edit_Catagory : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["con"].ConnectionString);
        SqlCommand cmd;
        SqlDataAdapter adp;
        DataTable dt = new DataTable();
        string query;
        SqlCommandBuilder cd;
        protected void Page_Load(object sender, EventArgs e)
        {
                query = "select* from Catagory ";
                cmd = new SqlCommand(query, con);
                adp = new SqlDataAdapter(cmd);
                cd = new SqlCommandBuilder(adp);
                adp.Fill(dt);
                if (!IsPostBack)
                {
                    Bind();
                }
          
            
        }
        public void Bind()
        {
            GridView1.DataSource = dt;
            GridView1.DataBind();

        }

        protected void btn_AddCatagory_Click(object sender, EventArgs e)
        {
            try
            {
                query = "_Check_Catagory";
                cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Catagory_name", txtCatName.Text.Trim());
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adp.Fill(dt);
                cd = new SqlCommandBuilder(adp);
                if (dt.Rows.Count > 0)
                {
                    Literal1.Text = "Record Is Duplicate";
                    txtCatName.Text = "";
                }
                else
                {
                    query = "_catagory";
                    cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Catagory_name", txtCatName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Admin_Eamil", Session["username"].ToString());
                    con.Open();
                    cmd.ExecuteNonQuery();
                    Literal1.Text = "Record Is Filled";
                    txtCatName.Text = "";
                    Response.AddHeader("refresh", "0");
  
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            Bind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            DataRow[] dr = dt.Select("Cat_id=" + Convert.ToInt32(GridView1.Rows[e.RowIndex].Cells[0].Text));
            dr[0].Delete();
            adp.Update(dt);
            Bind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            DataRow[] dr = dt.Select("Cat_id=" + Convert.ToInt32(GridView1.Rows[e.RowIndex].Cells[0].Text));
            dr[0][1] = ((TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0]).Text;
            dr[0][2] = ((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text;
            adp.Update(dt);
            GridView1.EditIndex = -1;
            Bind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            Bind();
        }
    }
}