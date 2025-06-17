using Components.Factions.Governments.Sub_Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Factions.Governments
{
    public class Government_Democracy : FactionGovernment_base
    {
        public bool YearsBetweenElections { get; set; }
        public System_Parliament Parliament { get; set; } = new System_Parliament();
        public DateTime NextElection {  get; set; }
    }
}
