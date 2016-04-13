using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameReviewWebPortal_SOC09109.Models
{
    /// <summary>
    /// User Model
    /// Used for linking with the local database to retrieve users
    /// </summary>
    public class Account
    {
        /// <summary>
        /// The ID of the user account
        /// </summary>
        public int AccountID { get; set; }

        [Required]
        [Display (Name ="First Name: ")]
        /// <summary>
        /// The users firstname
        /// </summary>
        public String User_Forename { get; set; }

        [Required]
        [Display(Name = "Surname: ")]
        /// <summary>
        /// The users surname
        /// </summary>
        public String User_Surname { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email Address: ")]
        /// <summary>
        /// The users email address
        /// </summary>
        public String User_E_Address { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(20,MinimumLength = 6)]
        [Display(Name = "Password: ")]
        /// <summary>
        /// The password for the user
        /// </summary>
        public String User_Password { get; set; }

        /// <summary>
        /// Used to determine if the user is an admin or not
        /// </summary>
        public bool Admin_Check { get; set; }
    }
}