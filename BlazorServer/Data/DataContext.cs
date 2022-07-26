using Microsoft.EntityFrameworkCore;

namespace BlazorServer.Data
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
                    Name = "God Of War",
                    Developer = "Santa Monica Studios",
                    Release = new DateTime(2018, 11, 15)
                },
                new Game
                {
                    Id = 2,
                    Name = "NBA 2K25",
                    Developer = "2k",
                    Release = new DateTime(2024, 11, 15)
                },
                new Game
                {
                    Id = 3,
                    Name = "Marvel's Spiderman",
                    Developer = "La gente dura",
                    Release = new DateTime(2018, 11, 15)
                }
            );
        }

        public DbSet<Game> Games => Set<Game>();
    }
}
