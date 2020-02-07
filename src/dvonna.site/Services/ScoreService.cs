using System.Collections.Generic;
using System.Threading.Tasks;
using dvonna.Shared;

namespace dvonna.Site.Services
{
    public class ScoreService : IScoreService
    {
        public Task<IEnumerable<PlayerScore>> GetTop5Async()
        {
            return Task.FromResult<IEnumerable<PlayerScore>>(new List<PlayerScore>
            {
                new PlayerScore
                {
                    Position = 1,
                    Name = "Piet"
                },
                new PlayerScore
                {
                    Position = 2,
                    Name = "Hendrik"
                },
                new PlayerScore
                {
                    Position = 3,
                    Name = "Linda"
                },
                new PlayerScore
                {
                    Position = 4,
                    Name = "Gerard"
                },
                new PlayerScore
                {
                    Position = 5,
                    Name = "Edna"
                }
            });
        }
    }
}
