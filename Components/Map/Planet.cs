
using Components.Factions;
using Components.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Map
{
    public class Planet : Component_Base
    {
        public List<PopulationUnit> Population { get; set; } = new List<PopulationUnit>();
        public Localisation Name { get; set; }
        public Faction Owner { get; set; }
    }
}
