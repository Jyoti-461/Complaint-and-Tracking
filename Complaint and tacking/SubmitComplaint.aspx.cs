using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Complaint_and_tacking
{
    public partial class SubmitComplaint : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(
            ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCategories();
            }
        }

        // Load categories into DropDownList
        void LoadCategories()
        {
            SqlCommand cmd = new SqlCommand(
                "SELECT CategoryId, CategoryName FROM Categories", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            ddlCategory.DataSource = dt;
            ddlCategory.DataTextField = "CategoryName";
            ddlCategory.DataValueField = "CategoryId";
            ddlCategory.DataBind();

            ddlCategory.Items.Insert(0, "--Select Category--");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
                return;

            try
            {
                string filePath = "";

                // File upload
                if (FileUpload1.HasFile)
                {
                    string ext = Path.GetExtension(FileUpload1.FileName);
                    string fileName = Guid.NewGuid().ToString() + ext;
                    filePath = "~/Uploads/" + fileName;
                    FileUpload1.SaveAs(Server.MapPath(filePath));
                }

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Complaints " +
                    "(StudentName, Email, Mobile, CategoryId, Subject, Description, FilePath) " +
                    "VALUES (@n,@e,@m,@c,@s,@d,@f)", con);

                cmd.Parameters.AddWithValue("@n", txtName.Text);
                cmd.Parameters.AddWithValue("@e", txtEmail.Text);
                cmd.Parameters.AddWithValue("@m", txtMobile.Text);
                cmd.Parameters.AddWithValue("@c", ddlCategory.SelectedValue);
                cmd.Parameters.AddWithValue("@s", txtSubject.Text);
                cmd.Parameters.AddWithValue("@d", txtDesc.Text);
                cmd.Parameters.AddWithValue("@f", filePath);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                lblMsg.Text = "Complaint Submitted Successfully";
                lblMsg.ForeColor = System.Drawing.Color.Green;

                ClearForm();
            }
            catch (Exception ex)
            {
                lblMsg.Text = "Error: " + ex.Message;
                lblMsg.ForeColor = System.Drawing.Color.Red;
            }
        }

        void ClearForm()
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtMobile.Text = "";
            txtSubject.Text = "";
            txtDesc.Text = "";
            ddlCategory.SelectedIndex = 0;
        }
    }
}
