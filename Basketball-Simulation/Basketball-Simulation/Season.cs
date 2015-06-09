using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basketball_Simulation
{
    public class Season
    {
        public League League { get; set; } // The league this season belongs to

        public short Year { get; set; } // The year this season started

        public List<Match> Matches; // Every match that happens during this season

        public Rules.SeasonRules Rules { get; set; }
    }
}
