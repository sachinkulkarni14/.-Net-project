using BAL;
using DAL;
using Hotel_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
namespace Hotel_Management.Controllers
{
    public class AdminController : ApiController
    {
        static IHotelComponent component = HotelFactory.GetComponent();


        private Adminclass Convert(Admin admin)
        {
            return new Adminclass
            {
                Adminid = admin.Adminid,
                AdminName = admin.AdminName,
                AdminEmail = admin.AdminEmail,
                Password = admin.Password

            };
        }
        private Admin Convert(Adminclass adm)
        {
            var admin = new Admin
            {
                Adminid = adm.Adminid,
                AdminName = adm.AdminName,
                AdminEmail = adm.AdminEmail,
                Password = adm.Password
            };
            return admin;

        }
        [HttpPost]
        public bool AddAdmin(Adminclass admins)
        {
            var admin = Convert(admins);
            component.AdminRegister(admin);
            return true;


        }
        [HttpPost]
        public bool AdminLogin(string email, string pwd)
        {
            component.AdminLogin(email, pwd);
            return true;
        }


    }


}
