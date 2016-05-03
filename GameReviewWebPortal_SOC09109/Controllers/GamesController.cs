using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GameReviewWebPortal_SOC09109.App_Data;
using GameReviewWebPortal_SOC09109.Models;

namespace GameReviewWebPortal_SOC09109.Controllers
{
    /// <summary>
    /// Controller Class GamesController
    /// By Mark McLaughlin 
    /// 40200606
    /// </summary>
    public class GamesController : Controller
    {
        //Local Database Instance
        private Data db = new Data();

        public Game UpdateModel
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Review UpdateModell
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        #region Game Admin
        // GET: Games
        public ActionResult Index(string email)
        {
            //Check email address for admin
            var account = db.Accounts.Where(a => (a.User_E_Address == email));
            if (account.Count() > 0)
            {
                if (account.First().Admin_Check == true)
                {
                    return View(db.Games.ToList());
                }
                else
                {
                    return HttpNotFound();
                }
            }
            return RedirectToAction("Index", "Home");
        }

        // GET: Games/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Game game = db.Games.Find(id);
            if (game == null)
            {
                return HttpNotFound();
            }
            return View(game);
        }

        // GET: Games/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: Review
        public ActionResult AddReview()
        {
            return View();
        }

        // POST: Games/AddReview
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddReview([Bind(Include = "Title,Description")] Review review, int id, string reviewer)
        {
            if (ModelState.IsValid)
            {
                //Find game
                Game game = db.Games.Find(id);
                //Set review to game
                review.Game = game;
                //Set reviewer email to review
                review.Reviewer = reviewer;
                db.Reviews.Add(review);
                db.SaveChanges();
            }
            return null;
        }

        // POST: Games/AddReview
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GameID,Name,Genre,Platform,Initial_Release_Date,Publisher,Developer,Plot,Rating,ImageName")] Game game)
        {
            if (ModelState.IsValid)
            {
                db.Games.Add(game);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(game);
        }


        // GET: Games/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Game game = db.Games.Find(id);
            if (game == null)
            {
                return HttpNotFound();
            }
            return View(game);
        }

        // POST: Games/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GameID,Name,Genre,Platform,Initial_Release_Date,Publisher,Developer,Plot,Rating,ImageName")] Game game)
        {
            if (ModelState.IsValid)
            {
                db.Entry(game).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(game);
        }

        // GET: Games/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Game game = db.Games.Find(id);
            if (game == null)
            {
                return HttpNotFound();
            }
            return View(game);
        }

        // POST: Games/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Game game = db.Games.Find(id);
            //Delete reviews of game
            db.Reviews.RemoveRange(game.Reviews);
            db.Games.Remove(game);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        #endregion

        #region User Pages

        /// <summary>
        /// Returns individual game by clicking on a game link
        /// </summary>
        /// <param name="id">The ID of the game</param>
        /// <returns>Returns game object if exists, returns no page if not</returns>
        public ActionResult IndividualGame(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Game game = db.Games.Find(id);
            if (game == null)
            {
                return HttpNotFound();
            }
            return View(game);
        }

        #endregion

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
