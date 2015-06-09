using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basketball_Simulation
{
    public class Match
    {
        public Season Season { get; set; } // The season that this match belongs to

        public Rules.MatchRules Rules { get; set; }
    }
}
