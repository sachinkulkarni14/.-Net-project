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
    public class RoomDetailsController : ApiController
    {
        static IHotelComponent component = HotelFactory.GetComponent();
        private HotelRoomsDetail Convert(RoomsDetail room)
        {
            return new HotelRoomsDetail
            {
                RoomNo = room.RoomNo,
                NumberofRooms = room.NumberofRooms,
                Price = room.Price,
                Roomtype = room.Roomtype,
                status = room.status

            };
        }
        private RoomsDetail Convert(HotelRoomsDetail hotels)
        {
            var room = new RoomsDetail
            {
                RoomNo = hotels.RoomNo,
                NumberofRooms = hotels.NumberofRooms,
                Price = hotels.Price,
                Roomtype = hotels.Roomtype,
                status = hotels.status

            };
            return room;
        }
        [HttpPost]
        public bool AddRoomDetails(HotelRoomsDetail hotels)
        {
            var room = Convert(hotels);
            component.AddRoomDetails(room);
            return true;
        }
        public bool DeleteRoomDetails(string id)
        {
            var roomid = int.Parse(id);
            component.DeleteRoomDetails(roomid);
            return true;
        }
        public List<HotelRoomsDetail> GetHotelRoomDetails()
        {
            var data = component.GetRoomDetails();
            var roomList = data.Select((r) => new HotelRoomsDetail
            {
                RoomNo = r.RoomNo,
                NumberofRooms = r.NumberofRooms,
                Price = r.Price,
                Roomtype = r.Roomtype,
                status = r.status

            }).ToList();
            return roomList;

        }
        [HttpPut]
        public bool UpdateRoomDetails(HotelRoomsDetail hrd)
        {
            var room = Convert(hrd);
            component.UpdateRoomDetails(room);
            return true;
        }
    }
}
