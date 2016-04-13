using GameReviewWebPortal_SOC09109.App_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameReviewWebPortal_SOC09109.Controllers
{
    public class HomeController : Controller
    {
        private Data db = new Data();
        // GET: Home
        public ActionResult Index()
        {
            var games = db.Games;
            return View(games);
        }
    }
}
