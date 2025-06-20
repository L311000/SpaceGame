using Components.Factions;
using Components.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Map
{
    public class Solar_System : Component_Base
    {
        public List<Planet> Planets { get; set; } = new List<Planet>();
        public Localisation Name { get; set; }
        public Faction Owner { get; set; }
        public Color Color_Sun { get; set; }
    }
}
