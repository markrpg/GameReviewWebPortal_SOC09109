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
    public class TestAccountsController
    {
        /// <summary>
        /// Method to test "Admin" method in "AccountsController"
        /// </summary>
        [TestMethod]
        public void TestAdmin()
        {
            //Create new instance of accounts controller
            var accounts = new AccountsController();

            //Pass admin email to check for admin status
            var result = accounts.Admin("test@mail.com") as ViewResult;

            //If not null, admin account verified
            Assert.IsNotNull(result);
        }

        /// <summary>
        /// Method to test "Login" method in "AccountsController"
        /// </summary>
        [TestMethod]
        public void TestLogin()
        {
            //Create new instance of accounts controller
            var accounts = new AccountsController();

            //Access login method
            var result = accounts.Login() as ViewResult;

            //If not null, login successful
            Assert.IsNotNull(result);
        }

        /// <summary>
        /// Method to test "Logout" method in "AccountsController"
        /// </summary>
        [TestMethod]
        public void TestLogout()
        {
            //Create new instance of accounts controller
            var accounts = new AccountsController();

            //Access logout method
            var result = accounts.Logout() as ViewResult;

            //If not null, logout successful
            Assert.IsNotNull(result);
        }

        /// <summary>
        /// Method to test "Register" method in "AccountsController"
        /// </summary>
        [TestMethod]
        public void TestRegister()
        {
            //Create new instance of accounts controller
            var accounts = new AccountsController();

            //Create Account using model and pass to Register method
            Account newAccount = new Account();
            newAccount.User_E_Address = "DummyEmail@email.com";
            newAccount.User_Forename = "John";
            newAccount.User_Surname = "Doe";
            newAccount.User_Password = "Test1234";
            var result = accounts.Register(newAccount) as ViewResult;

            //If not null, register successful
            Assert.IsNotNull(result);
        }


    }
}
