using System;
using GameReviewWebPortal_SOC09109.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
namespace GameReviewWebPortal_SOC09109.Tests
{
    [TestClass]
    public class AccountsControllerTests
    {
        /// <summary>
        /// Test harness for "Admin" Method in AccountsController
        /// </summary>
        [TestMethod]
        public void AdminMethodTest()
        {
            //Create new account controller for testing
            var acc = new AccountsController();
            Assert.Equals(typeof(ViewResult),acc.Admin("test@mail.com"));
        }
    }
}
