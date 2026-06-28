using CQRSWebApi.Data;
using CQRSWebApi.Features.Player.CreatePlayer;
using CQRSWebApi.Features.Player.GetPlayer;
using CQRSWebApi.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CQRSWebApi.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly ISender _sender;
        public PlayersController(ISender sender)
        {
            _sender = sender;
        }

        // GET: api/Player
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Player>>> GetPlayer()
        {
            var players = await _sender.Send(new GetPlayerQuery());
            return Ok(players);
        }

        // POST: api/Player
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Player>> PostPlayer(CreatePlayerCommand command)
        {
            int playerId = await _sender.Send(command);

            return Ok(playerId);
        }
    }
}
