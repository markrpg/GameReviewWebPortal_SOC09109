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
using System.Web.Security;

namespace GameReviewWebPortal_SOC09109.Controllers
{
    public class AccountsController : Controller
    {
        private Data db = new Data();

        #region Admin Pages

        /// <summary>
        /// Show all accounts
        /// </summary>
        /// <returns>List of accounts</returns>
        public ActionResult Index(int id)
        {
            return View(db.Accounts.ToList());
        }

        /// <summary>
        /// Admin Page 
        /// </summary>
        /// <returns></returns>
        public ActionResult Admin(int id)
        {

            //Check if user is admin before continuing
            //Get accounts from DB where the ID is current ID
            var account = db.Accounts.FirstOrDefault(a => a.AccountID == id);

            //If the account is admin 
            if (account.Admin_Check == true)
            {
                return View();
            }

            //Show error if not
            return HttpNotFound();
        }

        /// <summary>
        /// Get specific account details
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Returns specific account details</returns>
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Account account = db.Accounts.Find(id);
            if (account == null)
            {
                return HttpNotFound();
            }
            return View(account);
        }

        /// <summary>
        /// Used to create a new account through the admin
        /// </summary>
        /// <returns>Returns the create page</returns>
        public ActionResult Create()
        {
            return View();
        }


        /// <summary>
        /// Checks if account created by admin is valid
        /// </summary>
        /// <param name="account">The created account model</param>
        /// <returns>Redirects to index page</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AccountID,User_Forename,User_Surname,User_E_Address,User_Password,Admin_Check")] Account account)
        {
            if (ModelState.IsValid)
            {
                db.Accounts.Add(account);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(account);
        }


        /// <summary>
        /// Used to edit specific accounts
        /// </summary>
        /// <param name="id">The ID of the account to edit</param>
        /// <returns>Returns account</returns>
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Account account = db.Accounts.Find(id);
            if (account == null)
            {
                return HttpNotFound();
            }
            return View(account);
        }


        /// <summary>
        /// Checks if edited account details are valid
        /// </summary>
        /// <param name="account">account to edit</param>
        /// <returns>returns edited account</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AccountID,User_Forename,User_Surname,User_E_Address,User_Password,Admin_Check")] Account account)
        {
            if (ModelState.IsValid)
            {
                db.Entry(account).State = EntityState.Modified;
                db.SaveChanges();

                //If user is admin relist all accounts
                if (account.Admin_Check == true)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(account);
        }



        /// <summary>
        /// Used to delete specific accounts
        /// </summary>
        /// <param name="id">The ID of the account to delete.</param>
        /// <returns>returns account to delete</returns>
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Account account = db.Accounts.Find(id);
            if (account == null)
            {
                return HttpNotFound();
            }
            return View(account);
        }

        /// <summary>
        /// Used to remove account from database
        /// </summary>
        /// <param name="id">id of account to remove</param>
        /// <returns>redirects to index</returns>
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Account account = db.Accounts.Find(id);
            db.Accounts.Remove(account);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        #endregion


        #region User Pages

        /// <summary>
        /// Shows overview of the account.
        /// </summary>
        /// <returns></returns>
        public ActionResult Overview(string email)
        {
            //Get accounts from DB where the email is current email.
            var account = db.Accounts.FirstOrDefault(a => a.User_E_Address == email);

            //Return users overview page
            return View(account);
        }

        /// <summary>
        /// Login page used to facilitate in logging in
        /// </summary>
        /// <returns>Login View</returns>
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// Login page result, validates login
        /// </summary>
        /// <param name="accountLogin"></param>
        /// <returns>Redirect to Overview page.</returns>
        [HttpPost]
        public ActionResult Login(Models.Account accountLogin)
        {
            //Check if the account exists
            if (IsAccountValid(accountLogin.User_E_Address, accountLogin.User_Password))
            {
                //Set authentication cookie
                FormsAuthentication.SetAuthCookie(accountLogin.User_E_Address, false);
                //Redirect to accounts overview
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        /// <summary>
        /// Register Page facilitates in registering
        /// </summary>
        /// <returns>Returns the register view</returns>
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        /// <summary>
        /// Register page result, validates registration
        /// </summary>
        /// <param name="accountRegister"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Register(Models.Account accountRegister)
        {
            //Check if the account exists
            if (!IsAccountValid(accountRegister.User_E_Address, accountRegister.User_Password) && ModelState.IsValid)
            {
                //Create new account from details
                var newAccount = db.Accounts.Create();
                newAccount.User_Forename = accountRegister.User_Forename;
                newAccount.User_Surname = accountRegister.User_Surname;
                newAccount.User_E_Address = accountRegister.User_E_Address;
                newAccount.User_Password = accountRegister.User_Password;
               
                //Not an admin
                newAccount.Admin_Check = accountRegister.Admin_Check = false;

                //Add new account to database
                db.Accounts.Add(newAccount);

                //Save Database
                db.SaveChanges();

                //Set authentication cookie
                FormsAuthentication.SetAuthCookie(accountRegister.User_E_Address, false);

                //Redirect to accounts overview
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Incorrect Registration Data");
            }

            return View();
        }

        
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
   

        /// <summary>
        /// Used to validate a login
        /// </summary>
        /// <param name="email">The email to validate</param>
        /// <param name="password">The password to validate</param>
        /// <returns>Returns true if valid, false if not</returns>
        private bool IsAccountValid(string email, string password)
        {
            bool isValid = false;

            //Get accounts from DB where the email is current email.
            var account = db.Accounts.FirstOrDefault(a => a.User_E_Address == email);

            //Check if account exists and if password is valid
            if (account != null)
            {
                if (account.User_Password == password)
                {
                    isValid = true;
                }
            }

            return isValid;
        }

        /// <summary>
        /// Check if user is an admin
        /// </summary>
        /// <param name="userID">User ID to check</param>
        /// <returns>Returns true if admin, false if not</returns>
        public bool IsAdmin(string email)
        {
            //Local variable for storing admin result
            bool Admin = false;

            //Get accounts from DB where the ID is current ID
            var account = db.Accounts.FirstOrDefault(a => a.User_E_Address == email);

            //Check if account exists and if password is valid
            if (account.Admin_Check == true)
            {
                Admin = true;
            }

            return Admin;
        }

        #endregion

        /// <summary>
        /// Used for simply disposing of objects
        /// </summary>
        /// <param name="disposing"></param>
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
