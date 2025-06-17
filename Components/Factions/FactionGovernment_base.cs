using Components.Characters;
using Components.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Factions
{
    public class FactionGovernment_base : Component_Base
    {
        public FactionGovernmentCategories Category { get; set; }
        public Localisation Leader_Title_Male { get; set; }
        public Localisation Leader_Title_Female { get; set; }
        public Localisation Heir_Title_Male { get; set; }
        public Localisation Heir_Title_Female { get; set; }

        public Game_Character Leader_Primary { get; set; }
        public Game_Character Leader_Successor { get; set; }

        public bool HasElections { get; set; }
    }
}
