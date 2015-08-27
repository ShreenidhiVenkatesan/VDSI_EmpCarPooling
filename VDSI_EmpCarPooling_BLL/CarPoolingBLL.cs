using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VDSI_EmCarPooling_DAL;
using VDSI_EmpCarPooling_DTO;

namespace VDSI_EmpCarPooling_BLL
{

    
    public class CarPoolingBLL
    {
        public string getLoginDetails(string username,string password)
        {
           VDSI_CARPEntities entities = VDSI_CARPEntities.createInstance();


            var loginList = (from list in entities.LOGINs
                             where list.EmpName.Equals(username) && list.Password.Equals(password)
                             select list).ToList();
            if (loginList != null)            
                return loginList.Select(a => a.EmpId).ElementAtOrDefault(0);
            return null;
        }


        public void insertRegistrationDetails(CARREGDETAILDTO detail)
        {
            VDSI_CARPEntities entities = VDSI_CARPEntities.createInstance();
            CARREGDETAIL regDetail = new CARREGDETAIL();
            regDetail.EmpId = detail.EmpId;
            regDetail.Email = detail.Email;
            regDetail.From = detail.From;
            regDetail.To = detail.To;
            regDetail.InTime = detail.InTime;
            regDetail.OutTime = detail.OutTime;
            regDetail.Status = true;
            regDetail.Via = detail.Via;
            entities.CARREGDETAILS.Add(regDetail);
            entities.SaveChanges();
        }
    }
}
