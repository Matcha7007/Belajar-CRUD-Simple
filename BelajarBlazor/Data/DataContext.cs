using Microsoft.EntityFrameworkCore;

namespace BelajarBlazor.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>().HasData(
                    new Game 
                    { 
                        Id = 1, 
                        Name = "Dota 2", 
                        Developer = "Valve", 
                        Release = new DateTime(2013, 07, 09) 
                    },
                    new Game
                    {
                        Id = 2,
                        Name = "Resident Evil Village",
                        Developer = "Capcom",
                        Release = new DateTime(2021, 05, 02)
                    },
                    new Game
                    {
                        Id = 3,
                        Name = "Valorant",
                        Developer = "Riot Games",
                        Release = new DateTime(2020, 05, 02)
                    }
                );
        }
        public DbSet<Game> Games => Set<Game>();
    }

}
