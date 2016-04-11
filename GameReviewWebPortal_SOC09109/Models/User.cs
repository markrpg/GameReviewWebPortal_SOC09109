using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameReviewWebPortal_SOC09109.Models
{
    /// <summary>
    /// User Model
    /// Used for linking with the local database to retrieve users
    /// </summary>
    public class User
    {
        /// <summary>
        /// The ID of the user
        /// </summary>
        public int User_ID { get; set; }

        /// <summary>
        /// The users firstname
        /// </summary>
        public String User_Forename { get; set; }

        /// <summary>
        /// The users surname
        /// </summary>
        public String User_Surname { get; set; }
        
        /// <summary>
        /// The users email address
        /// </summary>
        public String User_E_Address { get; set; }

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