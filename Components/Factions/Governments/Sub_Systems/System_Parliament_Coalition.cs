using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Factions.Governments.Sub_Systems
{
    public class System_Parliament_Coalition : Component_Base
    {
        public List<System_Parliament_Party> Parties { get; set; } = new();
        public double CombinedParliamentInfluence { get => GetCombinedInfluence(); }

        private double GetCombinedInfluence()
        {
            double influence = 0;
            foreach (var party in Parties)
            {
                influence += party.ParliamentInfluence;
            }
            return influence;
        }
    }
}
