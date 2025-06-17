using Components.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Characters
{
    public class Family : Component_Base
    {
        public Localisation Name {  get; set; }
        public Localisation Prefix { get; set; }
        public List<Game_Character> Characters { get; set; } = new();
        public DateTime Founded { get; set; }
        public DateTime? Extinct { get; set; }
    }
}
