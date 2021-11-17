using System.Collections.Generic;
using System.Threading.Tasks;
using dvonna.Shared;
using Refit;

namespace dvonna.Site.Services
{
    public interface IPlayerService
    {
        [Get("/player-details.json")]
        Task<IEnumerable<PlayerDetails>> GetPlayersAsync();
    }
}
