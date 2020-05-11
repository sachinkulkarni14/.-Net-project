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
    public class BookingController : ApiController
    {
        static IHotelComponent component = HotelFactory.GetComponent();

        private UserBooking Convert(Booking book)
        {
            return new UserBooking
            {
                CName = book.CName,
                Checkin = book.Checkin,
                Checkout = book.Checkout,
                Numberofdays = book.Numberofdays,
                NumberofPersons = book.NumberofPersons,
                NumberofRooms = book.NumberofRooms,
                Phone = book.Phone,
                Price = book.Price,
                RoomNo = book.RoomNo,
                Roomtype = book.Roomtype,
                TotalAmount = book.TotalAmount

            };
        }
        private Booking Convert(UserBooking ub)
        {
            var book = new Booking
            {
                CName = ub.CName,
                Checkin = ub.Checkin,
                Checkout = ub.Checkout,
                Numberofdays = ub.Numberofdays,
                NumberofPersons = ub.NumberofPersons,
                NumberofRooms = ub.NumberofRooms,
                Phone = ub.Phone,
                Price = ub.Price,
                RoomNo = ub.RoomNo,
                Roomtype = ub.Roomtype,
                TotalAmount = ub.TotalAmount

            };
            return book;

        }
        [HttpPost]
        public bool AddBookingDetails(UserBooking userbooking)
        {
            var book = Convert(userbooking);
            component.AddBookingDetails(book);
            return true;
        }
        public List<UserBooking> GetBookingDetails()
        {
            var data = component.GetBookedReceipt();
            var booking = data.Select((r) => new UserBooking
            {
                CName = r.CName,
                Checkin = r.Checkin,
                Checkout = r.Checkout,
                Numberofdays = r.Numberofdays,
                NumberofPersons = r.NumberofPersons,
                NumberofRooms = r.NumberofRooms,
                Phone = r.Phone,
                Price = r.Price,
                RoomNo = r.RoomNo,
                Roomtype = r.Roomtype,
                TotalAmount = r.TotalAmount


            }).ToList();
            return booking;

        }

    }
}
