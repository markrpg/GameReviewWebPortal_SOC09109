using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameReviewWebPortal_SOC09109.Models
{
    /// <summary>
    /// Review Model
    /// Used to retrieve reviews from the local database
    /// </summary>
    public class Review
    {
        /// <summary>
        /// The Reviews ID
        /// </summary>
        public int ReviewID { get; set; }

        /// <summary>
        /// The reviewer
        /// </summary>
        public virtual Account Reviewer { get; set; }

        /// <summary>
        /// The title of the review
        /// </summary>
        public String Title { get; set; }

        /// <summary>
        /// The description of the review
        /// </summary>
        public String Description { get; set; }

        /// <summary>
        /// The ID of the comments left for this review
        /// </summary>
        public virtual List<Comment> Comments { get; set; }    
    }
}