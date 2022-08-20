using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u21512338_HW04.Models;

namespace u21512338_HW04.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult CurrentDonations()
        {
            return View();
        }

        public ActionResult Donation()
        {
            return View();
        }

        public ActionResult VolunteerResults()
        {
            return View();          
        }

        public ActionResult Volunteer()
        {
            return View();
        }

    }
}