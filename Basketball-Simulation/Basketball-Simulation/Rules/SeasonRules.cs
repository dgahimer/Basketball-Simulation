using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basketball_Simulation.Rules
{
    public class SeasonRules
    {
        public byte PreseasonGames { get; set; } // Number of preseason games per team
        public byte RegularSeasonGames { get; set; } // Number of regular season games per team
        public byte AllStarGames { get; set; }

        public byte PlayoffRounds { get; set; } // Number of rounds in the playoffs
        // TODO: Figure out a way to allow customization between round robin and head-to-head
        // TODO: Figure out a way to keep track of which teams get how many byes
    }
}
