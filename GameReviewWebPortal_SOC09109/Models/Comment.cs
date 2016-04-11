using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameReviewWebPortal_SOC09109.Models
{
    /// <summary>
    /// Comment Model
    /// Used to retrieve comments from the local database
    /// </summary>
    public class Comment
    {
        /// <summary>
        /// The Comments ID
        /// </summary>
        public int CommentID { get; set; }

        /// <summary>
        /// The Commentor
        /// </summary>
        public User Commentor { get; set; }

        /// <summary>
        /// The Review commented on
        /// </summary>
        public Review Commented_Review { get; set; }

        /// <summary>
        /// Contains the comment
        /// </summary>
        public String Comment_Value { get; set; }
    }
}