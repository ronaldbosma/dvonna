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
                Name = "Sara",
                PointsWon = 30,
                PointsLost = 11,
                NumberOfGamesPlayed = 12
            },
            new PlayerScore
            {
                Id = 1,
                Position = 2,
                Name = "Tom",
                PointsWon = 27,
                PointsLost = 9,
                NumberOfGamesPlayed = 9
            },
            new PlayerScore
            {
                Id = 2,
                Position = 3,
                Name = "Pete",
                PointsWon = 26,
                PointsLost = 13,
                NumberOfGamesPlayed = 10
            },
            new PlayerScore
            {
                Id = 6,
                Position = 4,
                Name = "Tamara",
                PointsWon = 21,
                PointsLost = 5,
                NumberOfGamesPlayed = 8
            },
            new PlayerScore
            {
                Id = 20,
                Position = 5,
                Name = "Rose",
                PointsWon = 12,
                PointsLost = 20,
                NumberOfGamesPlayed = 7
            },
            new PlayerScore
            {
                Id = 12,
                Position = 6,
                Name = "Justin",
                PointsWon = 12,
                PointsLost = 24,
                NumberOfGamesPlayed = 10
            },
            new PlayerScore
            {
                Id = 3,
                Position = 7,
                Name = "Hendrik",
                PointsWon = 11,
                PointsLost = 7,
                NumberOfGamesPlayed = 5
            },
            new PlayerScore
            {
                Id = 15,
                Position = 8,
                Name = "Harold",
                PointsWon = 10,
                PointsLost = 14,
                NumberOfGamesPlayed = 6
            },
            new PlayerScore
            {
                Id = 14,
                Position = 9,
                Name = "Johhny Q.",
                PointsWon = 10,
                PointsLost = 15,
                NumberOfGamesPlayed = 7
            },
            new PlayerScore
            {
                Id = 21,
                Position = 10,
                Name = "Carlos",
                PointsWon = 7,
                PointsLost = 11,
                NumberOfGamesPlayed = 5
            },
            new PlayerScore
            {
                Id = 13,
                Position = 11,
                Name = "Johnny H.",
                PointsWon = 7,
                PointsLost = 20,
                NumberOfGamesPlayed = 7
            },
            new PlayerScore
            {
                Id = 4,
                Position = 12,
                Name = "Lara",
                PointsWon = 6,
                PointsLost = 1,
                NumberOfGamesPlayed = 2
            },
            new PlayerScore
            {
                Id = 8,
                Position = 13,
                Name = "Anton",
                PointsWon = 5,
                PointsLost = 15,
                NumberOfGamesPlayed = 6
            },
            new PlayerScore
            {
                Id = 16,
                Position = 14,
                Name = "Sean",
                PointsWon = 3,
                PointsLost = 9,
                NumberOfGamesPlayed = 3
            },
            new PlayerScore
            {
                Id = 17,
                Position = 15,
                Name = "Rosalind",
                PointsWon = 2,
                PointsLost = 12,
                NumberOfGamesPlayed = 4
            },
            new PlayerScore
            {
                Id = 10,
                Position = 16,
                Name = "Jerry",
                PointsWon = 0,
                PointsLost = 0,
                NumberOfGamesPlayed = 0
            },
            new PlayerScore
            {
                Id = 23,
                Position = 17,
                Name = "Edna",
                PointsWon = 0,
                PointsLost = 0,
                NumberOfGamesPlayed = 0
            },
            new PlayerScore
            {
                Id = 5,
                Position = 18,
                Name = "Jason",
                PointsWon = 0,
                PointsLost = 3,
                NumberOfGamesPlayed = 1
            }
        };

        #endregion

        public Task<IEnumerable<PlayerScore>> GetTop5Async()
        {
            var top5 = _score.OrderBy(s => s.Position).Take(5);
            return Task.FromResult<IEnumerable<PlayerScore>>(top5);
        }

        public Task<IEnumerable<PlayerScore>> GetScoreAsync()
        {
            var score = _score.OrderBy(s => s.Position).Select(s => s);
            return Task.FromResult(score);
        }
    }
}
