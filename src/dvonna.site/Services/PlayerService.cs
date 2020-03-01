using System.Collections.Generic;
using System.Threading.Tasks;
using dvonna.Shared;
using System.Linq;

namespace dvonna.Site.Services
{
    public class PlayerService : IPlayerService
    {
        private static readonly IEnumerable<PlayerDetails> _playerDetails = new List<PlayerDetails>
        {
            new PlayerDetails
            {
                Id = 7,
                Position = 1,
                Name = "Sara",
                PointsWon = 30,
                PointsLost = 11,
                NumberOfGamesPlayed = 12
            },
            new PlayerDetails
            {
                Id = 1,
                Position = 2,
                Name = "Tom",
                PointsWon = 27,
                PointsLost = 9,
                NumberOfGamesPlayed = 9
            },
            new PlayerDetails
            {
                Id = 2,
                Position = 3,
                Name = "Pete",
                PointsWon = 26,
                PointsLost = 13,
                NumberOfGamesPlayed = 10
            },
            new PlayerDetails
            {
                Id = 6,
                Position = 4,
                Name = "Tamara",
                PointsWon = 21,
                PointsLost = 5,
                NumberOfGamesPlayed = 8
            },
            new PlayerDetails
            {
                Id = 20,
                Position = 5,
                Name = "Rose",
                PointsWon = 12,
                PointsLost = 20,
                NumberOfGamesPlayed = 7
            },
            new PlayerDetails
            {
                Id = 12,
                Position = 6,
                Name = "Justin",
                PointsWon = 12,
                PointsLost = 24,
                NumberOfGamesPlayed = 10
            },
            new PlayerDetails
            {
                Id = 3,
                Position = 7,
                Name = "Hendrik",
                PointsWon = 11,
                PointsLost = 7,
                NumberOfGamesPlayed = 5
            },
            new PlayerDetails
            {
                Id = 15,
                Position = 8,
                Name = "Harold",
                PointsWon = 10,
                PointsLost = 14,
                NumberOfGamesPlayed = 6
            },
            new PlayerDetails
            {
                Id = 14,
                Position = 9,
                Name = "Johhny Q.",
                PointsWon = 10,
                PointsLost = 15,
                NumberOfGamesPlayed = 7
            },
            new PlayerDetails
            {
                Id = 21,
                Position = 10,
                Name = "Carlos",
                PointsWon = 7,
                PointsLost = 11,
                NumberOfGamesPlayed = 5
            },
            new PlayerDetails
            {
                Id = 13,
                Position = 11,
                Name = "Johnny H.",
                PointsWon = 7,
                PointsLost = 20,
                NumberOfGamesPlayed = 7
            },
            new PlayerDetails
            {
                Id = 4,
                Position = 12,
                Name = "Lara",
                PointsWon = 6,
                PointsLost = 1,
                NumberOfGamesPlayed = 2
            },
            new PlayerDetails
            {
                Id = 8,
                Position = 13,
                Name = "Anton",
                PointsWon = 5,
                PointsLost = 15,
                NumberOfGamesPlayed = 6
            },
            new PlayerDetails
            {
                Id = 16,
                Position = 14,
                Name = "Sean",
                PointsWon = 3,
                PointsLost = 9,
                NumberOfGamesPlayed = 3
            },
            new PlayerDetails
            {
                Id = 17,
                Position = 15,
                Name = "Rosalind",
                PointsWon = 2,
                PointsLost = 12,
                NumberOfGamesPlayed = 4
            },
            new PlayerDetails
            {
                Id = 10,
                Position = 16,
                Name = "Jerry",
                PointsWon = 0,
                PointsLost = 0,
                NumberOfGamesPlayed = 0
            },
            new PlayerDetails
            {
                Id = 23,
                Position = 17,
                Name = "Edna",
                PointsWon = 0,
                PointsLost = 0,
                NumberOfGamesPlayed = 0
            },
            new PlayerDetails
            {
                Id = 5,
                Position = 18,
                Name = "Jason",
                PointsWon = 0,
                PointsLost = 3,
                NumberOfGamesPlayed = 1
            }
        };

        public Task<IDictionary<int, PlayerDetails>> GetPlayersAsync()
        {
            return Task.FromResult<IDictionary<int, PlayerDetails>>(_playerDetails.ToDictionary(p => p.Id, p => p));
        }
    }
}
