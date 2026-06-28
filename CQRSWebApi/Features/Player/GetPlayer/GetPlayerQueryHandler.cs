using CQRSWebApi.Data;
using CQRSWebApi.Models;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace CQRSWebApi.Features.Player.GetPlayer
{
    public class GetPlayerQueryHandler : IRequestHandler<GetPlayerQuery, IEnumerable<CQRSWebApi.Models.Player>>
    {
        private readonly InMemoryDbContext _context;
        public GetPlayerQueryHandler(InMemoryDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Models.Player>> Handle(GetPlayerQuery request, CancellationToken cancellationToken)
        {
            var players = await _context.Players.ToListAsync();
            return players;
        }
    }
}
