using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CapeMint_Project.Models
{
    public class MealViewModel
    {
        public string orderId { get; set; }
        [DisplayName("First Name")]
        [Required]
        public string FName { get; set; }

        [DisplayName("Surname")]
        [Required]
        public string LName { get; set; } 
        [DisplayName("Meal Type")]
        public int MealTypeId { get; set; }

        [DisplayName("Meal Details")]
        [Required]
        public string MealDetails { get; set; }
        [DisplayName("Hotel of resisdence")]
        public int hotelId { get; set; }
        
        public DateTime DateMade { get; set; }

        public Caterer Caterer { get; set; }
        [DisplayName("Meal Agents Available:")]
        public List<Caterer> CatererList { get; set; }

        public List<MealType> MealTypeList { get; set;}
        
        public List<Hotel> HotelList { get; set; }
    }
}