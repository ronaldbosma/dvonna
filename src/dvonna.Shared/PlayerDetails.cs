using System.Collections.Generic;

namespace dvonna.Shared
{
    public class PlayerDetails
    {
        public PlayerDetails()
        {
            OpponentToPlay = new List<Opponent>();
        }

        public int Id { get; set; }

        public int Position { get; set; }

        public string Name { get; set; }

        public int PointsWon { get; set; }

        public int PointsLost { get; set; }

        public int NumberOfGamesPlayed { get; set; }

        public IEnumerable<Opponent> OpponentToPlay { get; set; }
    }
}
