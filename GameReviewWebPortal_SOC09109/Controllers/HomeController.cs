using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameReviewWebPortal_SOC09109.Models.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: About Us
        public ActionResult AboutUs()
        {
            return View();
        }

        // GET: Contact Us
        public ActionResult ContactUs()
        {
            return View();
        }
    }
}