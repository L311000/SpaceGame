using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Factions.Governments.Sub_Systems
{
    public class System_Parliament : Component_Base
    {
        public List<System_Parliament_Party> Parties { get; set; } = new();
        public List<System_Parliament_Party> Coalitions { get; set; } = new();
        public List<System_Parliament_Party> Independent_Members { get; set; } = new();
        public double TotalInfluence { get; set; } = 100;
        public int SeatsAmount { get; set; }

        public void GenerateParliament()
        {

        }

        public void ImportParliament(object data)
        {

        }
    }
}
