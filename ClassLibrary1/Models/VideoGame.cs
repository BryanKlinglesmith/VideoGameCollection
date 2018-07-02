using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoGameCollection.Models
{
    public class VideoGame
    {
        public int Id { get; set; }
        public string GameTitle { get; set; }
        public string GameSystem { get; set; }
        public string Category { get; set; }
        public bool Favorite { get; set; }
    }
}