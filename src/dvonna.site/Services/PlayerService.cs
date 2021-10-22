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
                NumberOfGamesPlayed = 12,
                OpponentToPlay = new List<Opponent>
                {
                    new Opponent { Id = 3, Name = "Hendrik" },
                    new Opponent { Id = 4, Name = "Lara" },
                    new Opponent { Id = 5, Name = "Jason" },
                    new Opponent { Id = 10, Name = "Jerry" },
                    new Opponent { Id = 23, Name = "Edna" }
                }
            },
            new PlayerDetails
            {
                Id = 1,
                Position = 2,
                Name = "Tom",
                PointsWon = 27,
                PointsLost = 9,
                NumberOfGamesPlayed = 9,
                OpponentToPlay = new List<Opponent>
                {
                    new Opponent { Id = 2, Name = "Pete" },
                    new Opponent { Id = 4, Name = "Lara" },
                    new Opponent { Id = 5, Name = "Jason" },
                    new Opponent { Id = 8, Name = "Anton" },
                    new Opponent { Id = 10, Name = "Jerry" },
                    new Opponent { Id = 13, Name = "Johnny H." },
                    new Opponent { Id = 14, Name = "Johnny Q." },
                    new Opponent { Id = 23, Name = "Edna" }
                }
            },
            new PlayerDetails
            {
                Id = 2,
                Position = 3,
                Name = "Pete",
                PointsWon = 26,
                PointsLost = 13,
                NumberOfGamesPlayed = 10,
                OpponentToPlay = new List<Opponent>
                {
                    new Opponent { Id = 1, Name = "Tom" },
                    new Opponent { Id = 3, Name = "Hendrik" },
                    new Opponent { Id = 4, Name = "Lara" },
                    new Opponent { Id = 5, Name = "Jason" },
                    new Opponent { Id = 10, Name = "Jerry" },
                    new Opponent { Id = 21, Name = "Carlos" },
                    new Opponent { Id = 23, Name = "Edna" }
                }
            },
            new PlayerDetails
            {
                Id = 6,
                Position = 4,
                Name = "Tamara",
                PointsWon = 21,
                PointsLost = 5,
                NumberOfGamesPlayed = 8,
                OpponentToPlay = new List<Opponent>
                {
                    new Opponent { Id = 4, Name = "Lara" },
                    new Opponent { Id = 10, Name = "Jerry" },
                    new Opponent { Id = 12, Name = "Justin" },
                    new Opponent { Id = 13, Name = "Johnny H." },
                    new Opponent { Id = 15, Name = "Harold" },
                    new Opponent { Id = 16, Name = "Sean" },
                    new Opponent { Id = 17, Name = "Rosalind" },
                    new Opponent { Id = 20, Name = "Rose" },
                    new Opponent { Id = 23, Name = "Edna" }
                }
            },
            new PlayerDetails
            {
                Id = 20,
                Position = 5,
                Name = "Rose",
                PointsWon = 12,
                PointsLost = 20,
                NumberOfGamesPlayed = 7,
                OpponentToPlay = new List<Opponent>
                {
                    new Opponent { Id = 3, Name = "Hendrik" },
                    new Opponent { Id = 4, Name = "Lara" },
                    new Opponent { Id = 5, Name = "Jason" },
                    new Opponent { Id = 6, Name = "Tamara" },
                    new Opponent { Id = 8, Name = "Anton" },
                    new Opponent { Id = 10, Name = "Jerry" },
                    new Opponent { Id = 14, Name = "Johnny Q." },
                    new Opponent { Id = 16, Name = "Sean" },
                    new Opponent { Id = 17, Name = "Rosalind" },
                    new Opponent { Id = 20, Name = "Rose" },
                    new Opponent { Id = 21, Name = "Carlos" },
                    new Opponent { Id = 23, Name = "Edna" }
                }
            },
            new PlayerDetails
            {
                Id = 12,
                Position = 6,
                Name = "Justin",
                PointsWon = 12,
                PointsLost = 24,
                NumberOfGamesPlayed = 10,
                OpponentToPlay = new List<Opponent>()
            },
            new PlayerDetails
            {
                Id = 3,
                Position = 7,
                Name = "Hendrik",
                PointsWon = 11,
                PointsLost = 7,
                NumberOfGamesPlayed = 5,
                OpponentToPlay = new List<Opponent>()
            },
            new PlayerDetails
            {
                Id = 15,
                Position = 8,
                Name = "Harold",
                PointsWon = 10,
                PointsLost = 14,
                NumberOfGamesPlayed = 6,
                OpponentToPlay = new List<Opponent>()
            },
            new PlayerDetails
            {
                Id = 14,
                Position = 9,
                Name = "Johnny Q.",
                PointsWon = 10,
                PointsLost = 15,
                NumberOfGamesPlayed = 7,
                OpponentToPlay = new List<Opponent>()
            },
            new PlayerDetails
            {
                Id = 21,
                Position = 10,
                Name = "Carlos",
                PointsWon = 7,
                PointsLost = 11,
                NumberOfGamesPlayed = 5,
                OpponentToPlay = new List<Opponent>()
            },
            new PlayerDetails
            {
                Id = 13,
                Position = 11,
                Name = "Johnny H.",
                PointsWon = 7,
                PointsLost = 20,
                NumberOfGamesPlayed = 7,
                OpponentToPlay = new List<Opponent>()
            },
            new PlayerDetails
            {
                Id = 4,
                Position = 12,
                Name = "Lara",
                PointsWon = 6,
                PointsLost = 1,
                NumberOfGamesPlayed = 2,
                OpponentToPlay = new List<Opponent>()
            },
            new PlayerDetails
            {
                Id = 8,
                Position = 13,
                Name = "Anton",
                PointsWon = 5,
                PointsLost = 15,
                NumberOfGamesPlayed = 6,
                OpponentToPlay = new List<Opponent>()
            },
            new PlayerDetails
            {
                Id = 16,
                Position = 14,
                Name = "Sean",
                PointsWon = 3,
                PointsLost = 9,
                NumberOfGamesPlayed = 3,
                OpponentToPlay = new List<Opponent>()
            },
            new PlayerDetails
            {
                Id = 17,
                Position = 15,
                Name = "Rosalind",
                PointsWon = 2,
                PointsLost = 12,
                NumberOfGamesPlayed = 4,
                OpponentToPlay = new List<Opponent>()
            },
            new PlayerDetails
            {
                Id = 10,
                Position = 16,
                Name = "Jerry",
                PointsWon = 0,
                PointsLost = 0,
                NumberOfGamesPlayed = 0,
                OpponentToPlay = new List<Opponent>()
            },
            new PlayerDetails
            {
                Id = 23,
                Position = 17,
                Name = "Edna",
                PointsWon = 0,
                PointsLost = 0,
                NumberOfGamesPlayed = 0,
                OpponentToPlay = new List<Opponent>
                {
                    new Opponent { Id = 1, Name = "Tom" },
                    new Opponent { Id = 2, Name = "Pete" },
                    new Opponent { Id = 3, Name = "Hendrik" },
                    new Opponent { Id = 4, Name = "Lara" },
                    new Opponent { Id = 5, Name = "Jason" },
                    new Opponent { Id = 6, Name = "Tamara" },
                    new Opponent { Id = 7, Name = "Sara" },
                    new Opponent { Id = 8, Name = "Anton" },
                    new Opponent { Id = 10, Name = "Jerry" },
                    new Opponent { Id = 12, Name = "Justin" },
                    new Opponent { Id = 13, Name = "Johnny H." },
                    new Opponent { Id = 14, Name = "Johnny Q." },
                    new Opponent { Id = 15, Name = "Harold" },
                    new Opponent { Id = 16, Name = "Sean" },
                    new Opponent { Id = 17, Name = "Rosalind" },
                    new Opponent { Id = 20, Name = "Rose" },
                    new Opponent { Id = 21, Name = "Carlos" },
                    new Opponent { Id = 23, Name = "Edna" }
                }
            },
            new PlayerDetails
            {
                Id = 5,
                Position = 18,
                Name = "Jason",
                PointsWon = 0,
                PointsLost = 3,
                NumberOfGamesPlayed = 1,
                OpponentToPlay = new List<Opponent>()
            }
        };

        public Task<IDictionary<int, PlayerDetails>> GetPlayersAsync()
        {
            return Task.FromResult<IDictionary<int, PlayerDetails>>(_playerDetails.ToDictionary(p => p.Id, p => p));
        }
    }
}
