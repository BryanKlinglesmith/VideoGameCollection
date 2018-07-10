using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoGameCollection.Models
{
    public class VideoGameViewModel
    {
        private List<VideoGame> _videoGames;

        public VideoGameViewModel(List<VideoGame> videoGames)
        {
            _videoGames = videoGames;
        }

        public bool FavoritesChecked { get; set; }

        public List<VideoGame> Playstations
        {
            get
            {
                return _videoGames
                .Where(console => console.Console == "PS4")
                .ToList();
            }
        }

        public List<VideoGame> XBoxs
        {
            get
            {
                return _videoGames
                .Where(console => console.Console == "XB1")
                .ToList();
            }
        }

        public List<VideoGame> Switchs
        {
            get
            {
                return _videoGames
                .Where(console => console.Console == "SWITCH")
                .ToList();
            }
        }

        public List<VideoGame> FavPs4s
        {
            get
            {
                return _videoGames
                    .Where(vg => vg.Favorite == true
                    && vg.Console == "PS4")
                    .ToList();
            }
        }

        public List<VideoGame> FavXb1s
        {
            get
            {
                return _videoGames
                    .Where(vg => vg.Favorite == true
                    && vg.Console == "XB1")
                    .ToList();
            }
        }

        public List<VideoGame> FavSwitchs
        {
            get
            {
                return _videoGames
                    .Where(vg => vg.Favorite == true
                    && vg.Console == "SWITCH")
                    .ToList();
            }
        }
    }
}