using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using VideoGameCollection.Models;

namespace VideoGameCollection
{
    public class DatabaseInitializer
        : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            IList<VideoGame> videoGames = new List<VideoGame>();
            
            videoGames.Add(new VideoGame()
            { 
                GameTitle = "God of War",
                Console = "PS4",
                Favorite = true
            });

            videoGames.Add(new VideoGame()
            {
                GameTitle = "Forza Motorsports 7",
                Console = "XB1",
                Favorite = true
            });

            videoGames.Add(new VideoGame()
            {
                GameTitle = "Mario Odyssey",
                Console = "SWITCH",
                Favorite = false
            });

            context.VideoGames.AddRange(videoGames);

            context.SaveChanges();

            base.Seed(context);
        }
    }
}