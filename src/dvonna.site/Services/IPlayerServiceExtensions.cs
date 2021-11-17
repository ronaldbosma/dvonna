using System.Linq;
using System.Threading.Tasks;
using dvonna.Shared;

namespace dvonna.Site.Services
{
    internal static class IPlayerServiceExtensions
    {
        public static async Task<PlayerDetails> GetPlayerDetailsAsync(this IPlayerService playerService, int playerId)
        {
            var players = await playerService.GetPlayersAsync();
            return players.SingleOrDefault(p => p.Id == playerId);
        }
    }
}
