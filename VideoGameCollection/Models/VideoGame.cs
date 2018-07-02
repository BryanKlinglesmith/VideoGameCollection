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
        public string GameTitle { get; set; }
        public string Console { get; set; }

        [UIHint("Favorite")]
        public bool Favorite { get; set; }
    }
}