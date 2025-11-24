using CapeMint_Project.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Xml.Linq;

namespace CapeMint_Project.Controllers
{
    public class BookingController : Controller
    {
        private static IList<Booking> bookingsList = new List<Booking>();
        // GET: Booking
        public ActionResult MakeBooking(int hotelId)
        {
            ViewBag.HotelId = hotelId;
            //var hotelName = BookigRepository.GetHotelType()
            //.Where(b => b.HotelId == hotelId);
            var hotel = BookingRepository.GetHotels()
                .FirstOrDefault(b => b.HotelId == hotelId);

            ViewBag.Title = hotel.HotelName;
            ViewBag.selectedhotelId = hotelId;
            var ViewModel = new BookingViewModel
            {
                Hotels = BookingRepository.GetHotels(),
                Meals = hotel.MealTypes,
                Rooms = hotel.Rooms,
                Id = BookingRepository.GetIdTypes(),
            };
            return View(ViewModel);
        }

        public ActionResult BookingConfirmed()
        {

            var latestbooking = bookingsList.LastOrDefault();
            ViewBag.hotel = latestbooking.hotelName;

            return View(latestbooking);
        }
        public ActionResult getRooms (int hotelId, int roomId)
        {
            var hotel = BookingRepository.GetHotels().FirstOrDefault(b => b.HotelId == hotelId);
            var feature = hotel.Rooms.Where(r => r.roomTypeId == roomId).Select(r => r.roomFeatures).First();
            var price = hotel.Rooms.Where(r => r.roomTypeId == roomId).Select(r => r.roomPrice).First();
            return Content(
                string.Format("{0}", (feature+"/"+price)),
                "text/plain");
        }

        [HttpPost]
        public ActionResult saveCustomer(int hotelId, string Name, string Surname, string CInitials, string Cemail, int idTypeId,
            string idNumber, string DoB, string Address, string Tel, int RoomTypeId, int guestNo, int MealTypeID, string creationDate)
        {
            var hotel = BookingRepository.GetHotels()
                .FirstOrDefault(b => b.HotelId == hotelId);
            var idTypeName = BookingRepository.GetIdTypes().Where(i => i.Id == idTypeId).Select(i => i.Name).First();
            var MealTypes = hotel.MealTypes.Where(m=>m.MealId == MealTypeID).Select(m=> m.MealName).FirstOrDefault();
            var hotelName = hotel.HotelName;
            var room = hotel.Rooms.Where(r => r.roomTypeId ==RoomTypeId).First();
            Booking newCustomer = new Booking { Id= Guid.NewGuid(), FName= Name,LName= Surname, Initials= CInitials, email=Cemail,
                IdType=idTypeName,IdNumber=idNumber, birthday=DoB,address=Address,TelephoneNumber=Tel,roomType=room.roomTypeName,MealsReq =MealTypes,
                guestsNo= guestNo,DateMade= creationDate, roomPrice = room.roomPrice, hotelName = hotelName};
            bookingsList.Add(newCustomer);
            var newCustomerJSON = JsonConvert.SerializeObject(newCustomer);
            return Content(newCustomerJSON, "json");
        }
        /*public ActionResult saveCustomer(int hotelId)
        {
            var hotel = BookingRepository.GetHotels()
                .FirstOrDefault(b => b.HotelId == hotelId);
            /*var idTypeName = BookingRepository.GetIdTypes().Where(i => i.Id == idTypeId).Select(i => i.Name).First();
            /var MealTypes = hotel.MealTypes.Where(m => m.MealId == MealTypeID).Select(m => m.MealName).FirstOrDefault();
            var hotelName = hotel.HotelName;
            var roomName = hotel.Rooms.Where(r => r.roomTypeId == RoomTypeId).Select(r => r.roomTypeName).First();
            Booking newCustomer = new Booking
            {
                Id = Guid.NewGuid(),
                FName = Name,
                LName = Surname,
                Initials = CInitials,
                email = Cemail,
                IdType = idTypeName,
                IdNumber = idNumber,
                birthday = DoB,
                address = Address,
                TelephoneNumber = Tel,
                roomType = roomName,
                MealsReq = MealTypes,
                DateMade = creationDate
            };
            var newCustomerJSON = JsonConvert.SerializeObject(newCustomer);
            return Content("OK", "text/plain");
        }*/
    }
}