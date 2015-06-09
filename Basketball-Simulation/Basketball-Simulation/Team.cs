using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basketball_Simulation
{
    public class Team
    {
        public string Name { get; set; } // Name; ie: Indiana
        public string Nickname { get; set; } // Nickname; ie: Pacers
        public string Abbrev { get; set; } // The abbreviation of the team's name/nickname; ie: IND

        public List<Season> Seasons { get; set; } // List of seasons that this team belongs to. NOTE: Each

        public List<Player> Players { get; set; } // List of players contracted to the team

        public List<Team> MinorAffiliates { get; set; } // List of teams that are affiliated where this team is the parent club
        public List<Team> MajorAffiliates { get; set; } // List of teams that are affiliated where this team is the child club
    }
}
