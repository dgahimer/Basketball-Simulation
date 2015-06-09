using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basketball_Simulation
{
    public class Player
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<Team> Teams { get; set; } // All teams a player belongs to.
    }
}
