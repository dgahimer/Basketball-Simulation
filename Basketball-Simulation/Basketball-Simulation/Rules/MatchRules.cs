using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basketball_Simulation.Rules
{
    // Contains all the pertinant rules for a match
    public class MatchRules
    {
        public enum OvertimeType
        {
            None, // Draw after regulation
            Single, // Single overtime period, then draw
            Continuous // Overtime until a winner is decided
        };

        public int RegulationPeriod { get; set; } // Number of regulation periods
        public int RegulationPeriodLength { get; set; } // Length of regulation periods (in seconds)

        public OvertimeType Overtime { get; set; } // Overtime type for this game
        public int OvertimeLength { get; set; } // Length of each overtime period
    }
}
