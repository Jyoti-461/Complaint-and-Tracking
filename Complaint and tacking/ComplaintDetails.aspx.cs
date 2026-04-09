using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Complaint_and_tacking
{
    public partial class ComplaintDetails : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(
            ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString);

        int complaintId;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                complaintId = Convert.ToInt32(Request.QueryString["id"]);
                LoadComplaint();
            }
        }

        void LoadComplaint()
        {
            SqlCommand cmd = new SqlCommand(
                "SELECT Subject, Description, Status, AdminReply FROM Complaints WHERE ComplaintId=@id", con);

            cmd.Parameters.AddWithValue("@id", Request.QueryString["id"]);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                lblDetails.Text =
                    "<b>Subject:</b> " + dr["Subject"] + "<br/>" +
                    "<b>Description:</b> " + dr["Description"] + "<br/>" +
                    "<b>Status:</b> " + dr["Status"];

                txtReply.Text = dr["AdminReply"].ToString();
                ddlStatus.SelectedValue = dr["Status"].ToString();
            }

            con.Close();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(
                "UPDATE Complaints SET AdminReply=@r, Status=@s WHERE ComplaintId=@id", con);

            cmd.Parameters.AddWithValue("@r", txtReply.Text);
            cmd.Parameters.AddWithValue("@s", ddlStatus.SelectedValue);
            cmd.Parameters.AddWithValue("@id", Request.QueryString["id"]);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            lblMsg.Text = "Complaint Updated Successfully";
        }
    }
}