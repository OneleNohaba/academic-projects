using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace CapeMint_Project.Models
{
    public class BookingViewModel
    {
        public int selectedHotelId { get; set; }

        public int selectedIdType { get; set; }
      
        public int selectedMealTypeId { get; set; }

        public int selectedRoomId { get; set; }

        public List<IdType> Id { get; set; }
        
        public List<Hotel> Hotels { get; set; }
        [DisplayName("Meal req.")]
        public List<MealType> Meals { get; set; }
        
        [DisplayName("Room Type")]
        public List<Room> Rooms { get; set; }

    }

}