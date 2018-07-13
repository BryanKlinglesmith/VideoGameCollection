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

            videoGames.Add(new VideoGame()
            {
                GameTitle = "Detroit Become Human",
                Console = "PS4",
                Favorite = false
            });

            videoGames.Add(new VideoGame()
            {
                GameTitle = "Forza Motorsports 6",
                Console = "XB1",
                Favorite = false
            });

            videoGames.Add(new VideoGame()
            {
                GameTitle = "Zelda Breath of the Wild",
                Console = "SWITCH",
                Favorite = true
            });

            videoGames.Add(new VideoGame()
            {
                GameTitle = "NBA 2K18",
                Console = "PS4",
                Favorite = false
            });

            videoGames.Add(new VideoGame()
            {
                GameTitle = "Fallout 4",
                Console = "XB1",
                Favorite = false
            });

            videoGames.Add(new VideoGame()
            {
                GameTitle = "Assassin's Creed Odyssey",
                Console = "PS4",
                Favorite = true
            });

            videoGames.Add(new VideoGame()
            {
                GameTitle = "Forza Horizon 3",
                Console = "XB1",
                Favorite = false
            });

            videoGames.Add(new VideoGame()
            {
                GameTitle = "Horizon Zero Dawn",
                Console = "PS4",
                Favorite = true
            });

            videoGames.Add(new VideoGame()
            {
                GameTitle = "Red Dead Redemption",
                Console = "XB1",
                Favorite = true
            });

            videoGames.Add(new VideoGame()
            {
                GameTitle = "Minecraft",
                Console = "SWITCH",
                Favorite = true
            });

            videoGames.Add(new VideoGame()
            {
                GameTitle = "Stardew Valley",
                Console = "SWITCH",
                Favorite = false
            });



            context.VideoGames.AddRange(videoGames);

            context.SaveChanges();

            base.Seed(context);
        }
    }
}