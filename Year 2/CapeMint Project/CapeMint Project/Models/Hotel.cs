using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapeMint_Project.Models
{
    public class Hotel
    {
        public int HotelId { get; set; }

        public string HotelName { get; set;}
        
        public List<MealType> MealTypes { get; set; }

        public List<Room> Rooms { get; set; }
    }
}