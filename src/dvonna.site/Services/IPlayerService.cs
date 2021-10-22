using System.Collections.Generic;
using System.Threading.Tasks;
using dvonna.Shared;

namespace dvonna.Site.Services
{
    public interface IPlayerService
    {
        Task<PlayerDetails> GetPlayerDetailsAsync(int playerId);
     
        Task<IDictionary<int, PlayerDetails>> GetPlayersAsync();
    }
}
