using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Complaint_and_tacking
{
    public partial class TrackComplaint : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(
            ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(
                "SELECT ComplaintId, Subject, Status, AdminReply FROM Complaints WHERE Email=@e OR Mobile=@m", con);

            cmd.Parameters.AddWithValue("@e", txtSearch.Text);
            cmd.Parameters.AddWithValue("@m", txtSearch.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                string status = e.Row.Cells[2].Text.ToLower(); // Status column index

                if (status.Contains("open"))
                {
                    e.Row.Cells[2].CssClass = "status-open";
                }
                else if (status.Contains("progress"))
                {
                    e.Row.Cells[2].CssClass = "status-progress";
                }
                else if (status.Contains("resolved"))
                {
                    e.Row.Cells[2].CssClass = "status-resolved";
                }
            }
        }


    }
}