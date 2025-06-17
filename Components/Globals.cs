using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components
{
    public static class Globals
    {
        
        public static SessionSettings Settings_Game { get; set; }
        
    }

    public enum LocalisationLanguages
    {
        english, german
    }

    public enum FactionGovernmentCategories
    {
        none, democratic, oligarchy, dictatorial, monarchy_imperial, monarchy_feudal, corporate
    }

    public enum PartyIdeologies
    {
        none, conservative, progressive, liberal, anarchist, monarchist, fascist, nationalist, communist,
        socialist, populist
    }
}
