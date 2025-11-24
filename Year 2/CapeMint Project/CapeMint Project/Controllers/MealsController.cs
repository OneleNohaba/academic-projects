using CapeMint_Project.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace CapeMint_Project.Controllers
{
    public class MealsController : Controller
    {
        // GET: Meals

        public static List<Caterer> caterers = new List<Caterer>();
        private static List<MealType> selectedmealTypes = new List<MealType>();
        public ActionResult Order()
        {
            var ViewModel = new MealViewModel
            {
                CatererList = caterers,
                MealTypeList = BookingRepository.GetMealTypes(),
                HotelList = BookingRepository.GetHotels()
            };
            return View(ViewModel);
        }

        public ActionResult Caterer() {
           
            return View();
        }

        public ActionResult OrderConfirmed()
        {

            DateTime dateTime = DateTime.Now;
            ViewBag.date = dateTime.ToString("d");
            return View();
        }

        [HttpPost]
        public ActionResult AddCaterer(int Cat_Id, string Cat_FName, string Cat_LName, 
            string Cat_email, string Cat_Tel, string Cat_MealServices)
        {
            selectedmealTypes = JsonConvert.DeserializeObject<List<MealType>>(Cat_MealServices);
            Caterer caterer = new Caterer 
            {
                Id = Cat_Id,
                Cat_Name = Cat_FName,
                Cat_LName = Cat_LName,
                Cat_email = Cat_email,
                Cat_phone =Cat_Tel,
                MealServices = selectedmealTypes,
            };
            caterers.Add(caterer);

            // Return the view with the updated list
            return Content(caterers.Count.ToString(), "text/plain");
        }
        public ActionResult getUniques(int hotelId, int mealTypeId)
        {
            Guid id = Guid.NewGuid();
            string datenow = DateTime.Now.ToString("f");
            string hotel = BookingRepository.GetHotels().FirstOrDefault(b => b.HotelId == hotelId).HotelName;
            string MealName = BookingRepository.GetMealTypes().FirstOrDefault(m => m.MealId == mealTypeId).MealName;
            return Content(String.Format("{0}", (id.ToString() + "/" + datenow + "/" +hotel + "/" +MealName)),"text/plain");
        }
    }
}