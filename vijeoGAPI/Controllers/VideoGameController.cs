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

        [HttpGet]
        public ActionResult<List<VideoGame>> GetVideoGames()
        {
            return Ok(videoGames);
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<VideoGame> GetVideoGameById(int id)
        {
            var videoGame = videoGames.FirstOrDefault(x => x.Id == id);
            if (videoGame == null)
            {
                return NotFound();
            }
            return Ok(videoGame);
        }

        [HttpPost]
        public ActionResult<VideoGame> AddVideoGame (VideoGame newGame)
        {
            if (newGame == null)
                return BadRequest();

            newGame.Id = videoGames.Max(x => x.Id) + 1;
            videoGames.Add(newGame);
            return CreatedAtAction(nameof(GetVideoGameById), new { id = newGame.Id }, newGame);
            
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdateVideoGame(int id, VideoGame updates)
        {
            var game = videoGames.FirstOrDefault(x => x.Id == id);
            if (game is null)
                return NotFound();
            game.Title = updates.Title;
            game.Platform = updates.Platform;
            game.Developer = updates.Developer;
            game.Publisher = updates.Publisher;

            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteVideoGame (int id)
        {
            var game = videoGames.FirstOrDefault(x => x.Id == id);
            if (game is null)
                return NotFound();

            videoGames.Remove(game);
            return NoContent();
        }

    }
}
