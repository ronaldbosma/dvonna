using System.Collections.Generic;

namespace dvonna.Shared
{
    public class PlayerDetails
    {
        public PlayerDetails()
        {
            OpponentToPlay = new List<Opponent>();
            PlayedGames = new List<PlayedGame>();
        }

        public int Id { get; set; }

        public int Position { get; set; }

        public string Name { get; set; }

        public int TotalPointsWon { get; set; }

        public int TotalPointsLost { get; set; }

        public int NumberOfGamesPlayed { get; set; }

        public IEnumerable<Opponent> OpponentToPlay { get; set; }

        public IEnumerable<PlayedGame> PlayedGames { get; set; }
    }
}
