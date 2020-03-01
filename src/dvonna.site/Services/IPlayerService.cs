using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dvonna.Site.Services
{
    public interface IPlayerService
    {
        Task<IDictionary<int, PlayerDetails>> GetPlayersAsync();
    }
}
