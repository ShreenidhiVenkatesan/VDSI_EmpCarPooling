﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VDSI_EmpCarPooling.VDSI_EmpCarPooling_UI
{
    public partial class CarPooling_RegisterVehicle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["EmpId"] != null)
                txtEmpId.Text = Session["EmpId"].ToString();            
        }
    }
}