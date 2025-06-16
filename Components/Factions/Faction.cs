using Components.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Factions
{
    public class Faction
    {
        public Localisation Name { get; set; }
        public Localisation Adjective { get; set; }
        public Localisation Prefix { get; set; }
        public FactionGovernment_base Government { get; set; }

        public Color Color1 { get; set; }
        public Color Color2 { get; set; }
        public Color Color3 { get; set; }

        public bool Dynasty_CoA { get; set; }
    }
}
