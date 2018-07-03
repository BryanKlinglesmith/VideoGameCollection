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
    }
}