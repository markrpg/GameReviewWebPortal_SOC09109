using System;
using System.Data.Entity;
using System.Web.Mvc;
using GameReviewWebPortal_SOC09109.App_Data;
using GameReviewWebPortal_SOC09109.Controllers;
using GameReviewWebPortal_SOC09109.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameReviewWebPortalTests
{
    [TestClass]
    public class TestGamesController
    {
        /// <summary>
        /// Method to test "AddReview" method in "GamesController"
        /// </summary>
        [TestMethod]
        public void TestAddReview()
        {
            //Create new instance of accounts controller
            var games = new GamesController();

            //Create review and add to third game in database with test data
            Review review = new Review();
            review.Title = "This is a test Review";
            review.Description = "This is a test description for this review";
            int gameID = 2;
            string reviewerEmail = "test@mail.com";
            var result = games.AddReview(review,gameID,reviewerEmail) as ViewResult;

            //If not null, review successfully added
            Assert.IsNotNull(result);
        }

        /// <summary>
        /// Method to test "IndividualGame" method in "GamesController"
        /// </summary>
        [TestMethod]
        public void TestIndividualGame()
        {
            //Create new instance of accounts controller
            var games = new GamesController();

            //Try to access the third game in the database
            var result = games.IndividualGame(2) as ViewResult;

            //If not null, game successfully retrieved for viewing.
            Assert.IsNotNull(result);
        }


    }
}
