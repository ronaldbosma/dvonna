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

        //TODO: rename tot TotalPointsWon
        public int PointsWon { get; set; }

        //TODO: rename tot TotalPointsLost
        public int PointsLost { get; set; }

        public int NumberOfGamesPlayed { get; set; }

        public IEnumerable<Opponent> OpponentToPlay { get; set; }

        public IEnumerable<PlayedGame> PlayedGames { get; set; }
    }
}
