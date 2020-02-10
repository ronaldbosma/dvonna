using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dvonna.Shared;

namespace dvonna.Site.Services
{
    public class ScoreService : IScoreService
    {
        #region Test Data

        private static readonly IEnumerable<PlayerScore> _score = new List<PlayerScore>
        {
            new PlayerScore
            {
                Id = 7,
                Position = 1,
                Name = "Piet",
                PointsFor = 30,
                PointsAgainst = 11,
                NumberOfGamesPlayed = 12
            },
            new PlayerScore
            {
                Id = 1,
                Position = 2,
                Name = "Hendrik",
                PointsFor = 27,
                PointsAgainst = 9,
                NumberOfGamesPlayed = 9
            },
            new PlayerScore
            {
                Id = 2,
                Position = 3,
                Name = "Linda",
                PointsFor = 26,
                PointsAgainst = 13,
                NumberOfGamesPlayed = 10
            },
            new PlayerScore
            {
                Id = 6,
                Position = 4,
                Name = "Gerard",
                PointsFor = 21,
                PointsAgainst = 5,
                NumberOfGamesPlayed = 8
            },
            new PlayerScore
            {
                Id = 20,
                Position = 5,
                Name = "Edna",
                PointsFor = 12,
                PointsAgainst = 20,
                NumberOfGamesPlayed = 7
            },
            new PlayerScore
            {
                Id = 12,
                Position = 6,
                Name = "Tony",
                PointsFor = 12,
                PointsAgainst = 24,
                NumberOfGamesPlayed = 10
            },
            new PlayerScore
            {
                Id = 3,
                Position = 7,
                Name = "Tamara",
                PointsFor = 11,
                PointsAgainst = 7,
                NumberOfGamesPlayed = 5
            },
            new PlayerScore
            {
                Id = 15,
                Position = 8,
                Name = "Erica",
                PointsFor = 10,
                PointsAgainst = 14,
                NumberOfGamesPlayed = 6
            },
            new PlayerScore
            {
                Id = 14,
                Position = 9,
                Name = "Tom",
                PointsFor = 10,
                PointsAgainst = 15,
                NumberOfGamesPlayed = 7
            },
            new PlayerScore
            {
                Id = 21,
                Position = 10,
                Name = "Jason",
                PointsFor = 7,
                PointsAgainst = 11,
                NumberOfGamesPlayed = 5
            }
        };

        #endregion

        public Task<IEnumerable<PlayerScore>> GetTop5Async()
        {
            var top5 = _score.OrderBy(s => s.Position).Take(5);
            return Task.FromResult<IEnumerable<PlayerScore>>(top5);
        }
    }
}
