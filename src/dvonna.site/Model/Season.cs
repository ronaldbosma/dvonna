using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dvonna.site.Model
{
    public class Season
    {
        public List<Player> Players { get; } = new List<Player>();

        public List<Game> GamesPlayed { get; } = new List<Game>();
    }
}
