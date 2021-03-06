// <copyright file="AccountsControllerTest.cs">Copyright ©  2016</copyright>
using System;
using System.Web.Mvc;
using GameReviewWebPortal_SOC09109.Controllers;
using GameReviewWebPortal_SOC09109.Models;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameReviewWebPortal_SOC09109.Controllers.Tests
{
    /// <summary>This class contains parameterized unit tests for AccountsController</summary>
    [PexClass(typeof(AccountsController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class AccountsControllerTest
    {
        /// <summary>Test stub for Admin(String)</summary>
        [PexMethod]
        public ActionResult AdminTest(
            [PexAssumeUnderTest]AccountsController target,
            string AdminEmail
        )
        {
            ActionResult result = target.Admin(AdminEmail);
            return result;
            // TODO: add assertions to method AccountsControllerTest.AdminTest(AccountsController, String)
        }

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public AccountsController ConstructorTest()
        {
            AccountsController target = new AccountsController();
            return target;
            // TODO: add assertions to method AccountsControllerTest.ConstructorTest()
        }

        /// <summary>Test stub for Create()</summary>
        [PexMethod]
        public ActionResult CreateTest([PexAssumeUnderTest]AccountsController target)
        {
            ActionResult result = target.Create();
            return result;
            // TODO: add assertions to method AccountsControllerTest.CreateTest(AccountsController)
        }

        /// <summary>Test stub for Create(Account)</summary>
        [PexMethod]
        public ActionResult CreateTest01([PexAssumeUnderTest]AccountsController target, Account account)
        {
            ActionResult result = target.Create(account);
            return result;
            // TODO: add assertions to method AccountsControllerTest.CreateTest01(AccountsController, Account)
        }

        /// <summary>Test stub for DeleteConfirmed(Int32)</summary>
        [PexMethod]
        public ActionResult DeleteConfirmedTest([PexAssumeUnderTest]AccountsController target, int id)
        {
            ActionResult result = target.DeleteConfirmed(id);
            return result;
            // TODO: add assertions to method AccountsControllerTest.DeleteConfirmedTest(AccountsController, Int32)
        }

        /// <summary>Test stub for Delete(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public ActionResult DeleteTest(
            [PexAssumeUnderTest]AccountsController target,
            int? id
        )
        {
            ActionResult result = target.Delete(id);
            return result;
            // TODO: add assertions to method AccountsControllerTest.DeleteTest(AccountsController, Nullable`1<Int32>)
        }

        /// <summary>Test stub for Details(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public ActionResult DetailsTest(
            [PexAssumeUnderTest]AccountsController target,
            int? id
        )
        {
            ActionResult result = target.Details(id);
            return result;
            // TODO: add assertions to method AccountsControllerTest.DetailsTest(AccountsController, Nullable`1<Int32>)
        }

        /// <summary>Test stub for Edit(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public ActionResult EditTest(
            [PexAssumeUnderTest]AccountsController target,
            int? id
        )
        {
            ActionResult result = target.Edit(id);
            return result;
            // TODO: add assertions to method AccountsControllerTest.EditTest(AccountsController, Nullable`1<Int32>)
        }

        /// <summary>Test stub for Edit(Account)</summary>
        [PexMethod]
        public ActionResult EditTest01([PexAssumeUnderTest]AccountsController target, Account account)
        {
            ActionResult result = target.Edit(account);
            return result;
            // TODO: add assertions to method AccountsControllerTest.EditTest01(AccountsController, Account)
        }

        /// <summary>Test stub for Index(String)</summary>
        [PexMethod]
        public ActionResult IndexTest([PexAssumeUnderTest]AccountsController target, string email)
        {
            ActionResult result = target.Index(email);
            return result;
            // TODO: add assertions to method AccountsControllerTest.IndexTest(AccountsController, String)
        }

        /// <summary>Test stub for IsAdmin(String)</summary>
        [PexMethod]
        public bool IsAdminTest([PexAssumeUnderTest]AccountsController target, string email)
        {
            bool result = target.IsAdmin(email);
            return result;
            // TODO: add assertions to method AccountsControllerTest.IsAdminTest(AccountsController, String)
        }

        /// <summary>Test stub for Login()</summary>
        [PexMethod]
        public ActionResult LoginTest([PexAssumeUnderTest]AccountsController target)
        {
            ActionResult result = target.Login();
            return result;
            // TODO: add assertions to method AccountsControllerTest.LoginTest(AccountsController)
        }

        /// <summary>Test stub for Login(Account)</summary>
        [PexMethod]
        public ActionResult LoginTest01(
            [PexAssumeUnderTest]AccountsController target,
            Account accountLogin
        )
        {
            ActionResult result = target.Login(accountLogin);
            return result;
            // TODO: add assertions to method AccountsControllerTest.LoginTest01(AccountsController, Account)
        }

        /// <summary>Test stub for Logout()</summary>
        [PexMethod]
        public ActionResult LogoutTest([PexAssumeUnderTest]AccountsController target)
        {
            ActionResult result = target.Logout();
            return result;
            // TODO: add assertions to method AccountsControllerTest.LogoutTest(AccountsController)
        }

        /// <summary>Test stub for Overview(String)</summary>
        [PexMethod]
        public ActionResult OverviewTest([PexAssumeUnderTest]AccountsController target, string email)
        {
            ActionResult result = target.Overview(email);
            return result;
            // TODO: add assertions to method AccountsControllerTest.OverviewTest(AccountsController, String)
        }

        /// <summary>Test stub for Register()</summary>
        [PexMethod]
        public ActionResult RegisterTest([PexAssumeUnderTest]AccountsController target)
        {
            ActionResult result = target.Register();
            return result;
            // TODO: add assertions to method AccountsControllerTest.RegisterTest(AccountsController)
        }

        /// <summary>Test stub for Register(Account)</summary>
        [PexMethod]
        public ActionResult RegisterTest01(
            [PexAssumeUnderTest]AccountsController target,
            Account accountRegister
        )
        {
            ActionResult result = target.Register(accountRegister);
            return result;
            // TODO: add assertions to method AccountsControllerTest.RegisterTest01(AccountsController, Account)
        }
    }
}
