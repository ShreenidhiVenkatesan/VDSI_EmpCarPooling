using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VDSI_EmpCarPooling.VDSI_EmpCarPooling_UI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUserName.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                if (txtUserName.Text == "Shreenidhi")
                    Session["EmpId"] = "2550549";
                Response.Redirect("CarPooling_RegisterVehicle.aspx");
            }
        }
    }
}