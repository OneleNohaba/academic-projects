using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapeMint_Project.Models
{
    public class BookingRepository
    { 
        public static List<Hotel> GetHotels() 
        {
            return new List<Hotel>
            {
                new Hotel {HotelId=1,HotelName="CapeHoney", 
                    MealTypes =  new List<MealType>
                    {
                        new MealType {MealId=1,MealName="Regular"},
                        new MealType {MealId=2,MealName="Vegan"},
                        new MealType {MealId=6,MealName="Gluten-free"},
                    },
                Rooms = new List<Room>
                {
                    new Room {roomTypeId=4,roomTypeName="Standard", roomPrice=3000, roomFeatures =
                    "Breakfast excluded, single bed, TV, internet"},
                    new Room {roomTypeId=10,roomTypeName="Deluxe", roomPrice=5000, roomFeatures =
                    "Breakfast included, double (2) single beds, TV, internet"},
                    new Room {roomTypeId=8,roomTypeName="Exquisite", roomPrice=7000, roomFeatures =
                    "Breakfast included, queen-sized double beds, TV, internet, complimentary drinks in refrigerator"},
                    new Room {roomTypeId=9,roomTypeName="Executive", roomPrice= 10000, roomFeatures=
                    "Breakfast included, queen-sized double beds, TV, internet, complimentary " +
                    "drinks in refrigerator; laundry, room service, tourism tour of Capetropolis"}
                }
                },
                new Hotel {HotelId=2,HotelName="CapeIvory", MealTypes =  new List<MealType>
                    {
                        new MealType {MealId=1,MealName="Regular"},
                        new MealType {MealId=2,MealName="Vegan"},
                        new MealType {MealId=3,MealName="Halal"},
                        new MealType {MealId=4,MealName="Kosher"},
                        new MealType {MealId=5,MealName="Indian"},
                        new MealType {MealId=6,MealName="Gluten-free"},
                        new MealType {MealId=7,MealName="Keto"},
                        new MealType {MealId=8,MealName="Paleo"}
                    },
                    Rooms = new List<Room>
                    {
                        new Room {roomTypeId=1,roomTypeName="Single", roomPrice= 2500, 
                            roomFeatures= "Breakfast excluded; single bed, TV, internet"},
                        new Room {roomTypeId=3,roomTypeName="Double", roomPrice = 5000, 
                            roomFeatures= "Breakfast included, double (2) single beds, TV, internet"},
                         new Room {roomTypeId=9,roomTypeName="Executive", roomPrice=8000, 
                             roomFeatures = "Breakfast included, queen-sized double beds, TV, internet, complimentary \r\ndrinks in refrigerator; laundry, buffet voucher"}
                    }
                },
                new Hotel {HotelId=3,HotelName="CapeSweet", MealTypes =  new List<MealType>
                    {
                        new MealType {MealId=1,MealName="Regular"},
                        new MealType {MealId=2,MealName="Vegan"},
                        new MealType {MealId=3,MealName="Halal"},
                        new MealType {MealId=4,MealName="Kosher"},
                    },
                    Rooms = new List<Room>
                    {
                        new Room {roomTypeId=6,roomTypeName="Tasty", roomPrice=3500, roomFeatures=
                        "Breakfast included; two single beds, TV, internet"},
                        new Room {roomTypeId=5,roomTypeName="Comfort", roomPrice=5000, roomFeatures=
                        "Breakfast included, two single beds, TV, internet, laundry, free parking"},
                        new Room {roomTypeId=9,roomTypeName="Executive",roomPrice=9000, roomFeatures=
                        "Breakfast included, queen-sized double beds, TV, internet, complimentary " +
                        "drinks in refrigerator; laundry, free parking, pet allowed, separate dining area "},
                        new Room {roomTypeId=12,roomTypeName="Diamond", roomPrice=12000, roomFeatures=
                        "Breakfast included, queen-sized double beds, TV, internet, complimentary drinks in " +
                        "refrigerator; laundry, free parking, pet allowed, room service, separate dining area, buffet"},
                    }
                },
                new Hotel {HotelId=4,HotelName="CapeHive", MealTypes =  new List<MealType>
                    {
                        new MealType {MealId=1,MealName="Regular"},
                        new MealType {MealId=2,MealName="Vegan"},
                        new MealType {MealId=6,MealName="Gluten-free"},
                        new MealType {MealId=8,MealName="Paleo"}
                    },
                Rooms = new List<Room>
                {
                    new Room {roomTypeId=4,roomTypeName="Standard", roomPrice=5000, roomFeatures=
                    "Breakfast included, single bed, TV, internet, laundry, free parking"},
                    new Room {roomTypeId=2,roomTypeName="Double", roomPrice=7000, roomFeatures=
                    "Breakfast included, double (2) single beds, TV, internet"},
                    new Room {roomTypeId=9,roomTypeName="Executive", roomPrice=10000, roomFeatures=
                    "Breakfast included, queen-sized double beds, TV, internet, complimentary " +
                    "drinks in refrigerator; laundry, room service, tourism tour of Capetropolis"}
                }
                },
                new Hotel {HotelId=5,HotelName="CapeCow", MealTypes = new List<MealType>
                    {
                        new MealType {MealId=1,MealName="Regular"},
                        new MealType {MealId=2,MealName="Vegan"},
                        new MealType {MealId=3,MealName="Halal"},
                        new MealType {MealId=4,MealName="Kosher"},
                        new MealType {MealId=5,MealName="Indian"}
                    },
                Rooms= new List<Room>
                {
                    new Room {roomTypeId=3,roomTypeName="Budget", roomPrice=2500, roomFeatures=
                    "Breakfast excluded; single bed, TV, internet"},
                    new Room {roomTypeId=7,roomTypeName="Spotlight", roomPrice=4000, roomFeatures=
                    "Breakfast included; two single beds, TV, internet"},
                    new Room {roomTypeId=10,roomTypeName="Deluxe", roomPrice=6000,roomFeatures=
                    "Breakfast included, single bed, TV, internet, laundry, free parking, tourism tour of Capetropolis."},
                    new Room {roomTypeId=11,roomTypeName="Gold", roomPrice=8000, roomFeatures=
                    "Breakfast included, single bed, TV, internet, complimentary drinks in refrigerator, " +
                    "laundry, free parking, tourism tour of Capetropolis."},
                    new Room {roomTypeId=12,roomTypeName="Diamond",roomPrice=12000, roomFeatures=
                    "Breakfast included, queen-sized double beds, TV, internet, complimentary " +
                    "drinks in refrigerator; laundry, room service, tourism tour of Capetropolis"},
                    new Room {roomTypeId=13,roomTypeName="Platinum",roomPrice=15000,roomFeatures=
                    "Breakfast included, queen-sized double beds, TV, internet, complimentary " +
                    "drinks in refrigerator; laundry, room service, tourism tour of Capetropolis"},
                }
                },
            };
        }
        public static List<IdType> GetIdTypes()
        {
            return new List<IdType>()
            {
                new IdType { Id = 1, Name = "South African id" },
                new IdType { Id = 2, Name = "Passport" }
            };
        }
        public static List<MealType> GetMealTypes() 
        {
            return new List<MealType>
            {
                new MealType {MealId=1,MealName="Regular"},
                new MealType {MealId=2,MealName="Vegan"},
                new MealType {MealId=3,MealName="Halal"},
                new MealType {MealId=4,MealName="Kosher"},
                new MealType {MealId=5,MealName="Indian"},
                new MealType {MealId=6,MealName="Gluten-free"},
                new MealType {MealId=7,MealName="Keto"},
                new MealType {MealId=8,MealName="Paleo"},
            };
        }

       
        public static List<Room> GetRoomType()
        {
            return new List<Room>
            {
                new Room {roomTypeId=1,roomTypeName="Single"},
                new Room {roomTypeId=2,roomTypeName="Double"},
                new Room {roomTypeId=3,roomTypeName="Budget"},
                new Room {roomTypeId=4,roomTypeName="Standard"},
                new Room {roomTypeId=5,roomTypeName="Comfort"},
                new Room {roomTypeId=6,roomTypeName="Tasty"},
                new Room {roomTypeId=7,roomTypeName="Spotlight"},
                new Room {roomTypeId=8,roomTypeName="Exquisite"},
                new Room {roomTypeId=9,roomTypeName="Executive"},
                new Room {roomTypeId=10,roomTypeName="Deluxe"},
                new Room {roomTypeId=11,roomTypeName="Gold"},
                new Room {roomTypeId=12,roomTypeName="Diamond"},
                new Room {roomTypeId=13,roomTypeName="Platinum"},
            };
        }
     }
}