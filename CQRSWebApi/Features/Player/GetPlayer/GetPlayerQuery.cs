using MediatR;

namespace CQRSWebApi.Features.Player.GetPlayer
{
    public class GetPlayerQuery : IRequest<IEnumerable<CQRSWebApi.Models.Player>>
    {

    }
}
