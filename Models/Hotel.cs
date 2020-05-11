using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Management.Models
{
    public class Adminclass
    {
        public int Adminid { get; set; }
        public string AdminName { get; set; }
        public string AdminEmail { get; set; }
        public string Password { get; set; }
    }
    public class UserBooking
    {
        public int RoomNo { get; set; }
        public string CName { get; set; }
        public int NumberofPersons { get; set; }
        public decimal Price { get; set; }
        public int Numberofdays { get; set; }
        public System.DateTime Checkin { get; set; }
        public System.DateTime Checkout { get; set; }
        public string Roomtype { get; set; }
        public int NumberofRooms { get; set; }
        public decimal TotalAmount { get; set; }
        public long Phone { get; set; }

    }
    public partial class HotelRoomsDetail
    {
        public int RoomNo { get; set; }
        public int NumberofRooms { get; set; }
        public decimal Price { get; set; }
        public string Roomtype { get; set; }
        public string status { get; set; }

    }
    public class UserRegister
    {
        public long Phone { get; set; }
        public string CName { get; set; }
        public string Userid { get; set; }
        public string Password { get; set; }
        public long AadharNo { get; set; }
    }
}