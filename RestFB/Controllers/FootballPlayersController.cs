using Assingment1_FootballPlayers;
using Microsoft.AspNetCore.Mvc;
using RestFB.Managers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestFB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FootballPlayersController : ControllerBase
    {
        private readonly FootballPlayersManager _manager = new FootballPlayersManager();
        // GET: api/<FootballPlayerController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public ActionResult<List<FootballPlayer>> Get()
        {
            List<FootballPlayer> players = _manager.GetAll();

            if (players.Count() == 0) return NoContent();
            else { return Ok(players); }
        }

        // GET api/<FootballPlayerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<FootballPlayerController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<FootballPlayerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FootballPlayerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
