﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dvonna.site.Model
{
    public class Game
    {
        public Player Player1 { get; set; }

        public NumberOfLegs NumberOfLegsWonByPlayer1 { get; set; }

        public Player Player2 { get; set; }

        public NumberOfLegs NumberOfLegsWonByPlayer2 { get; set; }
    }
}
