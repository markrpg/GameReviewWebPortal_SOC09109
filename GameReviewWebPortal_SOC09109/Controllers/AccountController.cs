using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameReviewWebPortal_SOC09109.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account Overview
        public ActionResult Overview()
        {
            return View();
        }

        // GET: Login Page
        public ActionResult Login()
        {
            return View();
        }

        // GET: Register Page
        public ActionResult Register()
        {
            return View();
        }
    }
}