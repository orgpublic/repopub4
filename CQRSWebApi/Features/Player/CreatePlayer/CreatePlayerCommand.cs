using CQRSWebApi.Data;
using MediatR;

namespace CQRSWebApi.Features.Player.CreatePlayer
{
    public class CreatePlayerCommand : IRequest<int>
    {
        public string Name { get; set; } = string.Empty;
    }
}
