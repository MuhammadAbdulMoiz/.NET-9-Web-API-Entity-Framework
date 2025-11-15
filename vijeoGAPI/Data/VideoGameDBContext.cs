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
    }
}
