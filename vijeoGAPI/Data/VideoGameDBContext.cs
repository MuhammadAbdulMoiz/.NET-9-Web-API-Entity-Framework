using Microsoft.EntityFrameworkCore;

namespace vijeoGAPI.Data
{
    public class VideoGameDBContext : DbContext
    {
        public VideoGameDBContext(DbContextOptions<VideoGameDBContext> options)
            : base(options)
        {
        }

        public DbSet<VideoGame> VideoGames { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<VideoGame>().HasData(
                new VideoGame
                {
                    Id = 1,
                    Title = "The Legend of Zelda: Breath of the Wild",
                    Platform = "Nintendo Switch",
                    Developer = "Nintendo EPD",
                    Publisher = "Nintendo",
                },
                new VideoGame
                {
                    Id = 2,
                    Title = "God of War",
                    Platform = "PlayStation 4",
                    Developer = "Santa Monica Studio",
                    Publisher = "Sony Interactive Entertainment",
                },
                new VideoGame
                {
                    Id = 3,
                    Title = "Red Dead Redemption 2",
                    Platform = "PS 4",
                    Developer = "Rockstar Studios",
                    Publisher = "Rockstar Games",
                },
                new VideoGame
                {
                    Id = 4,
                    Title = "Halo Infinite",
                    Platform = "Xbox Series X",
                    Developer = "343 Industries",
                    Publisher = "Xbox Game Studios",
                });
        }
    }
}
