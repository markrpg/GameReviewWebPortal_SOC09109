using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameReviewWebPortal_SOC09109.Controllers
{
    public class GameController : Controller
    {
        // GET: Individual Game Page
        public ActionResult Game()
        {
            return View();
        }

        // GET: Games By Platform
        public ActionResult GamesByPlatform()
        {
            return View();
        }

        // GET: Top Games
        public ActionResult TopGames()
        {
            return View();
        }
    }
}