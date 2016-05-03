using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        /// The reviewer email
        /// </summary>
        public String Reviewer { get; set; }

        [Required]
        /// <summary>
        /// The title of the review
        /// </summary>
        public String Title { get; set; }

        [Required]
        /// <summary>
        /// The description of the review
        /// </summary>
        public String Description { get; set; }

        /// <summary>
        /// The Reviews game
        /// </summary>
        public virtual Game Game { get; set; }

        public CopyOfClass1 UpdateView
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}