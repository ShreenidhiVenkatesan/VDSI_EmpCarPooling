using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VDSI_EmpCarPooling_BLL;
using VDSI_EmpCarPooling_DTO;

namespace VDSI_EmpCarPooling.VDSI_EmpCarPooling_UI
{
    public partial class CarPooling_RegisterVehicle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["EmpId"] != null)
                txtEmpId.Text = Session["EmpId"].ToString();            
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            CARREGDETAILDTO carRegDetail = new CARREGDETAILDTO();
            carRegDetail.Email = txtEmail.Text;
            carRegDetail.EmpId = txtEmpId.Text;
            carRegDetail.From = txtFrom.Text;
            carRegDetail.To = txtTo.Text;
            carRegDetail.InTime = txtInTime.Text;
            carRegDetail.OutTime = txtOutTime.Text;
            carRegDetail.Via = txtVia.Text;
            CarPoolingBLL bll = new CarPoolingBLL();
            bll.insertRegistrationDetails(carRegDetail);
        }
    }
}