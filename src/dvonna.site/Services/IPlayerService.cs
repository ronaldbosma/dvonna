using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dvonna.Shared;

namespace dvonna.Site.Services
{
    public interface IPlayerService
    {
        Task<IDictionary<int, PlayerDetails>> GetPlayersAsync();
    }
}
