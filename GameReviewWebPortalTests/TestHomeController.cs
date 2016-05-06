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
    public class TestHomeController
    {
        /// <summary>
        /// Method to test "Genres" method in "HomeController"
        /// </summary>
        [TestMethod]
        public void TestGenres()
        {
            //Create new instance of home controller
            var home = new HomeController();

            //Pass genre and return filtered games list page
            var result = home.Genres("Action") as ViewResult;

            //If not null, filtered game list retrieved
            Assert.IsNotNull(result);
        }

        /// <summary>
        /// Method to test "Platform" method in "HomeController"
        /// </summary>
        [TestMethod]
        public void TestPlatform()
        {
            //Create new instance of home controller
            var home = new HomeController();

            //Pass platform and return filtered games list page
            var result = home.Genres("Xbox") as ViewResult;

            //If not null, filtered game list retrieved
            Assert.IsNotNull(result);
        }

        /// <summary>
        /// Method to test "SearchGame" method in "HomeController"
        /// </summary>
        [TestMethod]
        public void TestSearchGame()
        {
            //Create new instance of home controller
            var home = new HomeController();

            //Pass string and return filtered games list page by name
            var result = home.Genres("Call") as ViewResult;

            //If not null, filtered game list retrieved
            Assert.IsNotNull(result);
        }

    }
}
