using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace vijeoGAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGameController : ControllerBase
    {
        public static List<VideoGame> videoGames = new List<VideoGame>
        {
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
        };
    }
}
