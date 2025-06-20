using Components.Characters;
using Components.Graphical;
using Components.Interface;
using Components.Map;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Components.Factions
{
    public class Faction : Component_Base
    {
        public Planet Capital {  get; set; }
        public Localisation Name { get; set; }
        public Localisation Adjective { get; set; }
        public Localisation Prefix { get; set; }
        public FactionGovernment_base Government { get; set; }
        public CoA_Information CoA { get; set; }

        public Color Color1 { get; set; }
        public Color Color2 { get; set; }
        public Color Color3 { get; set; }

        //public bool Dynasty_CoA { get; set; }
        public Namelist Namelist { get; set; }
    }
}
