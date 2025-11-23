using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapeMint_Project.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            DateTime dateTime = DateTime.Now;

            ViewBag.Month = dateTime.ToString("Y");
            ViewBag.date = dateTime.ToString("d");
            return View();
        }
    }
}