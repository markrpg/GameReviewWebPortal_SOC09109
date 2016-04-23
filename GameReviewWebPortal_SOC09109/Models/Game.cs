using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameReviewWebPortal_SOC09109.Models
{
    /// <summary>
    /// Game Model
    /// Contains structure of game for linking to the local database.
    /// </summary>
    public class Game
    {
        /// <summary>
        /// The ID of the game
        /// </summary>
        public int GameID { get; set; }

        /// <summary>
        /// Reviews for the game
        /// </summary>
        public virtual List<Review> Reviews { get; set; }

        /// <summary>
        /// Name of the game
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// Genre of the game
        /// </summary>
        public String Genre { get; set; }

        /// <summary>
        /// Platform for the game
        /// </summary>
        public String Platform { get; set; }

        [Display(Name = "Release Date: ")]
        /// <summary>
        /// Date of games release
        /// </summary>
        public DateTime Initial_Release_Date { get; set; }

        /// <summary>
        /// Publisher of the game
        /// </summary>
        public String Publisher { get; set; }

        /// <summary>
        /// Developer of the game
        /// </summary>
        public String Developer { get; set; }

        /// <summary>
        /// List containing all the games rewards
        /// </summary>
        public virtual List<String> Awards { get; set; }

        /// <summary>
        /// The games plot
        /// </summary>
        public String Plot { get; set; }

        /// <summary>
        /// Returns the games image name
        /// </summary>
        public String ImageName { get; set; }

        /// <summary>
        /// The games rating
        /// </summary>
        public int Rating { get; set; }

    }
}