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
    public class UserController : ApiController
    {
        static IHotelComponent component = HotelFactory.GetComponent();

        private UserRegister Convert(Signup sign)
        {
            return new UserRegister
            {
                CName = sign.CName,
                Phone = sign.Phone,
                AadharNo = sign.AadharNo,
                Userid = sign.Userid,
                Password = sign.Password
            };
        }
        private Signup Convert(UserRegister user)
        {
            var sign = new Signup
            {
                CName = user.CName,
                Phone = user.Phone,
                AadharNo = user.AadharNo,
                Userid = user.Userid,
                Password = user.Password
            };
            return sign;
        }
        [HttpPost]
        public bool AddUser(UserRegister users)
        {
            var sign = Convert(users);
            component.UserSignup(sign);
            return true;
        }
        [HttpPost]
        public bool UserLogin(string userid, string pwd)
        {
            component.UserLogin(userid, pwd);
            return true;
        }

    }
}
