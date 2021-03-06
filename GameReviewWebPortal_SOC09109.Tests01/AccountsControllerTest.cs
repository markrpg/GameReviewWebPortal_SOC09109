using System;
using System.Web.Mvc;
using GameReviewWebPortal_SOC09109.Controllers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="AccountsControllerTest.cs">Copyright ©  2016</copyright>

namespace GameReviewWebPortal_SOC09109.Tests
{
    /// <summary>This class contains parameterized unit tests for AccountsController</summary>
    [PexClass(typeof(AccountsController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class AccountsControllerTest
    {
        [TestMethod]
        public void TestAdmin()
        {
            Assert.AreEqual(typeof(ViewResult),AdminTest(ConstructorTest(), "test@mail.com"));
        }

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public AccountsController ConstructorTest()
        {
            var target = new AccountsController();
            return target;
        }

        /// <summary>Test stub for Admin(String)</summary>
        [PexMethod]
        public ActionResult AdminTest([PexAssumeUnderTest]AccountsController target, string adminEmail)
        {
            var result = target.Admin(adminEmail);
            return result;
        }

    }
}
