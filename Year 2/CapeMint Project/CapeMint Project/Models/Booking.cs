using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace CapeMint_Project.Models
{
    public class Booking
    {
        [DisplayName("Booking ID")]
        public Guid Id { get; set; }

        [DisplayName("First Name")]
        public string FName { get; set; }

        [DisplayName("Surname")]
        public string LName { get; set; }

        [DisplayName("Initials")]
        public string Initials { get; set; }

        [DisplayName("E-mail")]
        public string email { get; set; }

        [DisplayName("ID Type")]
        public string IdType { get; set; }

        [DisplayName("ID Number")]
        public string IdNumber { get; set; }

        [DisplayName("Date of Birth")]
        public string birthday { get; set; }

        [DisplayName("Address")]
        public string address { get; set; }

        [DisplayName("Telephone")]
        public string TelephoneNumber { get; set; }

        [DisplayName("Meals Req.")]
        public string MealsReq { get; set; }
        [DisplayName("Hotel Booked @")]
        public string hotelName { get; set; }

        [DisplayName("Room Type")]
        public string roomType { get; set; }
        [DisplayName("Number of Guests In Room")]
        public int guestsNo { get; set; } = 1;

        [DisplayName("Price")]
        public int roomPrice { get; set; }
        [DisplayName("Date of Booking")]
        public string DateMade { get; set; }
    }
}