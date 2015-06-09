using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basketball_Simulation
{
    public class League
    {
        public string Name { get; set; } // The league name
        public string Abbrev { get; set; } // The abbreviation of the league name

        public List<Season> Seasons { get; set; } // List of every season the league has played
        
        public Rules.LeagueRules Rules { get; set; }
    }
}
