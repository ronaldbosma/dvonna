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
                Name = "Johnny Q.",
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

        private static readonly IEnumerable<DartOverviewRow> DartOverviewScore = new List<DartOverviewRow>
        {
            new DartOverviewRow
            {
                PlayerId = 1,
                PlayerName = "Tom",
                PointsWon = 27,
                PointsLost = 9,
                NumberOfGamesPlayed = 9,
                PointsWonAgainstOtherPlayer = new Dictionary<int, int?>
                {
                    {1, null},
                    {2, null},
                    {3, 3},
                    {4, null},
                    {5, null},
                    {6, 3},
                    {7, 3},
                    {8, null},
                    {10, null},
                    {12, 3},
                    {13, null},
                    {14, null},
                    {15, 3},
                    {16, 3},
                    {17, 3},
                    {20, 3},
                    {21, 3},
                    {23, null},
                }
            },
            new DartOverviewRow
            {
                PlayerId = 2,
                PlayerName = "Pete",
                PointsWon = 26,
                PointsLost = 13,
                NumberOfGamesPlayed = 10,
                PointsWonAgainstOtherPlayer = new Dictionary<int, int?>
                {
                    {1, null},
                    {2, null},
                    {3, null},
                    {4, null},
                    {5, null},
                    {6, 1},
                    {7, 3},
                    {8, 3},
                    {10, null},
                    {12, 1},
                    {13, 3},
                    {14, 3},
                    {15, 3},
                    {16, 3},
                    {17, 3},
                    {20, 3},
                    {21, null},
                    {23, null},
                }
            },
            new DartOverviewRow
            {
                PlayerId = 3,
                PlayerName = "Hendrik",
                PointsWon = 11,
                PointsLost = 7,
                NumberOfGamesPlayed = 5,
                PointsWonAgainstOtherPlayer = new Dictionary<int, int?>
                {
                    {1, 2},
                    {2, null},
                    {3, null},
                    {4, null},
                    {5, null},
                    {6, 0},
                    {7, null},
                    {8, null},
                    {10, null},
                    {12, 3},
                    {13, 3},
                    {14, null},
                    {15, null},
                    {16, null},
                    {17, 3},
                    {20, null},
                    {21, null},
                    {23, null},
                }
            },
            new DartOverviewRow
            {
                PlayerId = 4,
                PlayerName = "Lara",
                PointsWon = 6,
                PointsLost = 1,
                NumberOfGamesPlayed = 2,
                PointsWonAgainstOtherPlayer = new Dictionary<int, int?>
                {
                    {1, null},
                    {2, null},
                    {3, null},
                    {4, null},
                    {5, null},
                    {6, null},
                    {7, null},
                    {8, 3},
                    {10, null},
                    {12, 3},
                    {13, null},
                    {14, null},
                    {15, null},
                    {16, null},
                    {17, null},
                    {20, null},
                    {21, null},
                    {23, null},
                }
            },
            new DartOverviewRow
            {
                PlayerId = 5,
                PlayerName = "Jason",
                PointsWon = 0,
                PointsLost = 3,
                NumberOfGamesPlayed = 1,
                PointsWonAgainstOtherPlayer = new Dictionary<int, int?>
                {
                    {1, null},
                    {2, null},
                    {3, null},
                    {4, null},
                    {5, null},
                    {6, 0},
                    {7, null},
                    {8, null},
                    {10, null},
                    {12, null},
                    {13, null},
                    {14, null},
                    {15, null},
                    {16, null},
                    {17, null},
                    {20, null},
                    {21, null},
                    {23, null},
                }
            },
            new DartOverviewRow
            {
                PlayerId = 6,
                PlayerName = "Tamara",
                PointsWon = 21,
                PointsLost = 5,
                NumberOfGamesPlayed = 8,
                PointsWonAgainstOtherPlayer = new Dictionary<int, int?>
                {
                    {1, 0},
                    {2, 3},
                    {3, 3},
                    {4, null},
                    {5, 3},
                    {6, null},
                    {7, 3},
                    {8, 3},
                    {10, null},
                    {12, null},
                    {13, null},
                    {14, 3},
                    {15, null},
                    {16, null},
                    {17, null},
                    {20, null},
                    {21, 3},
                    {23, null},
                }
            },
            new DartOverviewRow
            {
                PlayerId = 7,
                PlayerName = "Sara",
                PointsWon = 30,
                PointsLost = 11,
                NumberOfGamesPlayed = 12,
                PointsWonAgainstOtherPlayer = new Dictionary<int, int?>
                {
                    {1, 1},
                    {2, 2},
                    {3, null},
                    {4, null},
                    {5, null},
                    {6, 0},
                    {7, null},
                    {8, 3},
                    {10, null},
                    {12, 3},
                    {13, 3},
                    {14, 3},
                    {15, 3},
                    {16, 3},
                    {17, 3},
                    {20, 3},
                    {21, 3},
                    {23, null},
                }
            },
            new DartOverviewRow
            {
                PlayerId = 8,
                PlayerName = "Anton",
                PointsWon = 5,
                PointsLost = 15,
                NumberOfGamesPlayed = 6,
                PointsWonAgainstOtherPlayer = new Dictionary<int, int?>
                {
                    {1, null},
                    {2, 0},
                    {3, null},
                    {4, 1},
                    {5, null},
                    {6, 0},
                    {7, 0},
                    {8, null},
                    {10, null},
                    {12, 1},
                    {13, null},
                    {14, 3},
                    {15, null},
                    {16, null},
                    {17, null},
                    {20, null},
                    {21, null},
                    {23, null},
                }
            },
            new DartOverviewRow
            {
                PlayerId = 10,
                PlayerName = "Jerry",
                PointsWon = 0,
                PointsLost = 0,
                NumberOfGamesPlayed = 0,
                PointsWonAgainstOtherPlayer = new Dictionary<int, int?>
                {
                    {1, null},
                    {2, null},
                    {3, null},
                    {4, null},
                    {5, null},
                    {6, null},
                    {7, null},
                    {8, null},
                    {10, null},
                    {12, null},
                    {13, null},
                    {14, null},
                    {15, null},
                    {16, null},
                    {17, null},
                    {20, null},
                    {21, null},
                    {23, null},
                }
            },
            new DartOverviewRow
            {
                PlayerId = 12,
                PlayerName = "Justin",
                PointsWon = 12,
                PointsLost = 24,
                NumberOfGamesPlayed = 10,
                PointsWonAgainstOtherPlayer = new Dictionary<int, int?>
                {
                    {1, 0},
                    {2, 3},
                    {3, 0},
                    {4, 0},
                    {5, null},
                    {6, null},
                    {7, 0},
                    {8, 3},
                    {10, null},
                    {12, null},
                    {13, 2},
                    {14, 1},
                    {15, null},
                    {16, null},
                    {17, null},
                    {20, 3},
                    {21, 0},
                    {23, null},
                }
            },
            new DartOverviewRow
            {
                PlayerId = 13,
                PlayerName = "Johnny H.",
                PointsWon = 7,
                PointsLost = 20,
                NumberOfGamesPlayed = 7,
                PointsWonAgainstOtherPlayer = new Dictionary<int, int?>
                {
                    {1, null},
                    {2, 0},
                    {3, 1},
                    {4, null},
                    {5, null},
                    {6, null},
                    {7, 0},
                    {8, null},
                    {10, null},
                    {12, 3},
                    {13, null},
                    {14, 1},
                    {15, 0},
                    {16, null},
                    {17, null},
                    {20, 2},
                    {21, null},
                    {23, null},
                }
            },
            new DartOverviewRow
            {
                PlayerId = 14,
                PlayerName = "Johnny Q.",
                PointsWon = 10,
                PointsLost = 15,
                NumberOfGamesPlayed = 7,
                PointsWonAgainstOtherPlayer = new Dictionary<int, int?>
                {
                    {1, null},
                    {2, 0},
                    {3, null},
                    {4, null},
                    {5, null},
                    {6, 1},
                    {7, 0},
                    {8, 0},
                    {10, null},
                    {12, 3},
                    {13, 3},
                    {14, null},
                    {15, 3},
                    {16, null},
                    {17, null},
                    {20, null},
                    {21, null},
                    {23, null},
                }
            },
            new DartOverviewRow
            {
                PlayerId = 15,
                PlayerName = "Harold",
                PointsWon = 10,
                PointsLost = 14,
                NumberOfGamesPlayed = 6,
                PointsWonAgainstOtherPlayer = new Dictionary<int, int?>
                {
                    {1, 2},
                    {2, 0},
                    {3, null},
                    {4, null},
                    {5, null},
                    {6, null},
                    {7, 1},
                    {8, null},
                    {10, null},
                    {12, null},
                    {13, 3},
                    {14, 1},
                    {15, null},
                    {16, null},
                    {17, null},
                    {20, 3},
                    {21, null},
                    {23, null},
                }
            },
            new DartOverviewRow
            {
                PlayerId = 16,
                PlayerName = "Sean",
                PointsWon = 3,
                PointsLost = 9,
                NumberOfGamesPlayed = 3,
                PointsWonAgainstOtherPlayer = new Dictionary<int, int?>
                {
                    {1, 1},
                    {2, 2},
                    {3, null},
                    {4, null},
                    {5, null},
                    {6, null},
                    {7, 0},
                    {8, null},
                    {10, null},
                    {12, null},
                    {13, null},
                    {14, null},
                    {15, null},
                    {16, null},
                    {17, null},
                    {20, null},
                    {21, null},
                    {23, null},
                }
            },
            new DartOverviewRow
            {
                PlayerId = 17,
                PlayerName = "Rosalind",
                PointsWon = 2,
                PointsLost = 12,
                NumberOfGamesPlayed = 4,
                PointsWonAgainstOtherPlayer = new Dictionary<int, int?>
                {
                    {1, 1},
                    {2, 1},
                    {3, 0},
                    {4, null},
                    {5, null},
                    {6, null},
                    {7, 0},
                    {8, null},
                    {10, null},
                    {12, null},
                    {13, null},
                    {14, null},
                    {15, null},
                    {16, null},
                    {17, null},
                    {20, null},
                    {21, null},
                    {23, null},
                }
            },
            new DartOverviewRow
            {
                PlayerId = 20,
                PlayerName = "Rose",
                PointsWon = 12,
                PointsLost = 20,
                NumberOfGamesPlayed = 7,
                PointsWonAgainstOtherPlayer = new Dictionary<int, int?>
                {
                    {1, 2},
                    {2, 2},
                    {3, null},
                    {4, null},
                    {5, null},
                    {6, null},
                    {7, 0},
                    {8, null},
                    {10, null},
                    {12, 1},
                    {13, 3},
                    {14, null},
                    {15, 2},
                    {16, null},
                    {17, null},
                    {20, null},
                    {21, 2},
                    {23, null},
                }
            },
            new DartOverviewRow
            {
                PlayerId = 21,
                PlayerName = "Carlos",
                PointsWon = 7,
                PointsLost = 11,
                NumberOfGamesPlayed = 5,
                PointsWonAgainstOtherPlayer = new Dictionary<int, int?>
                {
                    {1, 0},
                    {2, null},
                    {3, null},
                    {4, null},
                    {5, null},
                    {6, 0},
                    {7, 1},
                    {8, null},
                    {10, null},
                    {12, 3},
                    {13, null},
                    {14, null},
                    {15, null},
                    {16, null},
                    {17, null},
                    {20, 3},
                    {21, null},
                    {23, null},
                }
            },
            new DartOverviewRow
            {
                PlayerId = 23,
                PlayerName = "Edna",
                PointsWon = 0,
                PointsLost = 0,
                NumberOfGamesPlayed = 0,
                PointsWonAgainstOtherPlayer = new Dictionary<int, int?>
                {
                    {1, null},
                    {2, null},
                    {3, null},
                    {4, null},
                    {5, null},
                    {6, null},
                    {7, null},
                    {8, null},
                    {10, null},
                    {12, null},
                    {13, null},
                    {14, null},
                    {15, null},
                    {16, null},
                    {17, null},
                    {20, null},
                    {21, null},
                    {23, null},
                }
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

        public Task<IEnumerable<DartOverviewRow>> GetDartOverviewAsync()
        {
            return Task.FromResult(DartOverviewScore);
        }
    }
}
