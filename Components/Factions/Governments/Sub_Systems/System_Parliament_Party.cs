using Components.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Factions.Governments.Sub_Systems
{
    public class System_Parliament_Party
    {
        public List<Game_Character> Members { get; set; } = new();
        public Game_Character Head { get; set; }
        public Game_Character Co_Head { get; set; }
        public PartyIdeologies Ideology { get; set; }
        public double ParliamentInfluence { get; set; }
    }
}
