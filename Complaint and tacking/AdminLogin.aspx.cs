using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Complaint_and_tacking
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string adminUser = ConfigurationManager.AppSettings["AdminUser"];
            string adminPass = ConfigurationManager.AppSettings["AdminPass"];

            if (txtUser.Text == adminUser && txtPass.Text == adminPass)
            {
                Session["admin"] = "true";
                Response.Redirect("AdminDashboard.aspx");
            }
            else
            {
                lblMsg.Text = "Invalid Username or Password";
                lblMsg.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}