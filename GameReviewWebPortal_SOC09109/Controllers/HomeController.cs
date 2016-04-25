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
        //Database
        private Data db = new Data();

        // GET: Home
        public ActionResult Index()
        {
            var games = db.Games;
            return View(games);
        }

        // GET: Home , Genres
        public ActionResult Genres(string genre)
        {
            //Find all games with particular genre
            var games = db.Games.Where(a => (a.Genre == genre));
            return View(games);
        }

        // GET: Home , Platform
        public ActionResult Platform(string platform)
        {
            //Find all games with particular genre
            var games = db.Games.Where(a => (a.Platform == platform));
            return View(games);
        }

        [HttpPost]
        // GET: Home , Search Bar
        public ActionResult SearchGame(string game)
        {
            //Find all games with particular genre
            var games = db.Games.Where(a => (a.Name.Contains(game)));
            return View(games);
        }
    }
}
