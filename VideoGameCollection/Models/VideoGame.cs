using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VideoGameCollection.Models
{
    public class VideoGame
    {
        public int Id { get; set; }

        /// <summary>
        /// I am making gametitle a required field so that blank entries
        /// aren't submitted to the database. I'm also limiting the 
        /// max number of characters allowed for the game titles.
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string GameTitle { get; set; }

        public string Console { get; set; }

        /// <summary>
        /// Favorite is a display template in the shared views folder.  
        /// I'm using it to display either "Yes" or "No" instead of 
        /// an image of checkbox with a check or an empty checkbox
        /// on the Index view page
        /// </summary>
        [UIHint("Favorite")]
        public bool Favorite { get; set; }
    }
}