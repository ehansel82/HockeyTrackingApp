using System.Data.Entity;

namespace HockeyTrackingApp.Models.DAL
{
    public class HockeyAppContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Stats> Stats { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Put fluent API model building code here.
        }
    }
}