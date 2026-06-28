using CQRSWebApi.Data;
using CQRSWebApi.Models;
using MediatR;

namespace CQRSWebApi.Features.Player.CreatePlayer
{
    public class CreatePlayerCommandHandler : IRequestHandler<CreatePlayerCommand, int>
    {
        private readonly InMemoryDbContext _context;
        public CreatePlayerCommandHandler(InMemoryDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreatePlayerCommand request, CancellationToken cancellationToken)
        {
            var player = new CQRSWebApi.Models.Player() { Name = request.Name };
            _context.Players.Add(player);
            await _context.SaveChangesAsync();

            return player.Id;
        }
    }
}
