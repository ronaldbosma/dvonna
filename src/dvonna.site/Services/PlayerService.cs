﻿using System.Collections.Generic;
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
                TotalPointsWon = 30,
                TotalPointsLost = 11,
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
                TotalPointsWon = 27,
                TotalPointsLost = 9,
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
                TotalPointsWon = 26,
                TotalPointsLost = 13,
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
                },
                PlayedGames = new List<PlayedGame>
                {
                    new PlayedGame
                    {
                        Opponent = new Opponent { Id = 3, Name = "Tamara"},
                        PointsWon = 1,
                        PointsLost = 3
                    },
                    new PlayedGame
                    {
                        Opponent = new Opponent { Id = 7, Name = "Sara"},
                        PointsWon = 3,
                        PointsLost = 2
                    },
                    new PlayedGame
                    {
                        Opponent = new Opponent { Id = 8, Name = "Anton"},
                        PointsWon = 3,
                        PointsLost = 0
                    },
                    new PlayedGame
                    {
                        Opponent = new Opponent { Id = 12, Name = "Justin"},
                        PointsWon = 1,
                        PointsLost = 3
                    },
                    new PlayedGame
                    {
                        Opponent = new Opponent { Id = 13, Name = "Johnny H."},
                        PointsWon = 3,
                        PointsLost = 0
                    },
                    new PlayedGame
                    {
                        Opponent = new Opponent { Id = 14, Name = "Johnny Q."},
                        PointsWon = 3,
                        PointsLost = 0
                    },
                    new PlayedGame
                    {
                        Opponent = new Opponent { Id = 15, Name = "Harold"},
                        PointsWon = 3,
                        PointsLost = 0
                    },
                    new PlayedGame
                    {
                        Opponent = new Opponent { Id = 16, Name = "Sean"},
                        PointsWon = 3,
                        PointsLost = 2
                    },
                    new PlayedGame
                    {
                        Opponent = new Opponent { Id = 17, Name = "Rosalind"},
                        PointsWon = 3,
                        PointsLost = 1
                    },
                    new PlayedGame
                    {
                        Opponent = new Opponent { Id = 20, Name = "Rose"},
                        PointsWon = 3,
                        PointsLost = 2
                    }
                }
            },
            new PlayerDetails
            {
                Id = 6,
                Position = 4,
                Name = "Tamara",
                TotalPointsWon = 21,
                TotalPointsLost = 5,
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
                TotalPointsWon = 12,
                TotalPointsLost = 20,
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
                TotalPointsWon = 12,
                TotalPointsLost = 24,
                NumberOfGamesPlayed = 10,
                OpponentToPlay = new List<Opponent>()
            },
            new PlayerDetails
            {
                Id = 3,
                Position = 7,
                Name = "Hendrik",
                TotalPointsWon = 11,
                TotalPointsLost = 7,
                NumberOfGamesPlayed = 5,
                OpponentToPlay = new List<Opponent>()
            },
            new PlayerDetails
            {
                Id = 15,
                Position = 8,
                Name = "Harold",
                TotalPointsWon = 10,
                TotalPointsLost = 14,
                NumberOfGamesPlayed = 6,
                OpponentToPlay = new List<Opponent>()
            },
            new PlayerDetails
            {
                Id = 14,
                Position = 9,
                Name = "Johnny Q.",
                TotalPointsWon = 10,
                TotalPointsLost = 15,
                NumberOfGamesPlayed = 7,
                OpponentToPlay = new List<Opponent>()
            },
            new PlayerDetails
            {
                Id = 21,
                Position = 10,
                Name = "Carlos",
                TotalPointsWon = 7,
                TotalPointsLost = 11,
                NumberOfGamesPlayed = 5,
                OpponentToPlay = new List<Opponent>()
            },
            new PlayerDetails
            {
                Id = 13,
                Position = 11,
                Name = "Johnny H.",
                TotalPointsWon = 7,
                TotalPointsLost = 20,
                NumberOfGamesPlayed = 7,
                OpponentToPlay = new List<Opponent>()
            },
            new PlayerDetails
            {
                Id = 4,
                Position = 12,
                Name = "Lara",
                TotalPointsWon = 6,
                TotalPointsLost = 1,
                NumberOfGamesPlayed = 2,
                OpponentToPlay = new List<Opponent>()
            },
            new PlayerDetails
            {
                Id = 8,
                Position = 13,
                Name = "Anton",
                TotalPointsWon = 5,
                TotalPointsLost = 15,
                NumberOfGamesPlayed = 6,
                OpponentToPlay = new List<Opponent>()
            },
            new PlayerDetails
            {
                Id = 16,
                Position = 14,
                Name = "Sean",
                TotalPointsWon = 3,
                TotalPointsLost = 9,
                NumberOfGamesPlayed = 3,
                OpponentToPlay = new List<Opponent>()
            },
            new PlayerDetails
            {
                Id = 17,
                Position = 15,
                Name = "Rosalind",
                TotalPointsWon = 2,
                TotalPointsLost = 12,
                NumberOfGamesPlayed = 4,
                OpponentToPlay = new List<Opponent>()
            },
            new PlayerDetails
            {
                Id = 10,
                Position = 16,
                Name = "Jerry",
                TotalPointsWon = 0,
                TotalPointsLost = 0,
                NumberOfGamesPlayed = 0,
                OpponentToPlay = new List<Opponent>()
            },
            new PlayerDetails
            {
                Id = 23,
                Position = 17,
                Name = "Edna",
                TotalPointsWon = 0,
                TotalPointsLost = 0,
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
                TotalPointsWon = 0,
                TotalPointsLost = 3,
                NumberOfGamesPlayed = 1,
                OpponentToPlay = new List<Opponent>()
            }
        };

        public async Task<PlayerDetails> GetPlayerDetailsAsync(int playerId)
        {
            var players = await GetPlayersAsync();
            return players.SingleOrDefault(p => p.Id == playerId);
        }

        public Task<IDictionary<int, PlayerDetails>> GetPlayersAsyncOld()
        {
            return Task.FromResult<IDictionary<int, PlayerDetails>>(_playerDetails.ToDictionary(p => p.Id, p => p));
        }

        public Task<IEnumerable<PlayerDetails>> GetPlayersAsync()
        {
            return Task.FromResult(_playerDetails);
            //return Task.FromResult<IDictionary<int, PlayerDetails>>(_playerDetails.ToDictionary(p => p.Id, p => p));
        }
    }
}
