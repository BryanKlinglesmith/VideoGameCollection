using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using VideoGameCollection.Models;

namespace VideoGameCollection
{
    public class Context : DbContext
    {
 
        public Context()
        {
            Database.SetInitializer<Context>(new DatabaseInitializer());
        }

        public DbSet<VideoGame> VideoGames { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Removing the pluralizing table name convention 
            // so our table names will use our entity class singular names.
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }
    }
}