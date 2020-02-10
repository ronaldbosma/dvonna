using System;
using System.Collections.Generic;
using System.Text;

namespace dvonna.Shared
{
    public class DartOverviewRow
    {
        public int PlayerId { get; set; }

        public string PlayerName { get; set; }

        public IDictionary<int, int?> PointsWonAgainstOtherPlayer { get; set; }

        public int PointsWon { get; set; }

        public int PointsLost { get; set; }

        public int NumberOfGamesPlayed { get; set; }
    }
}
