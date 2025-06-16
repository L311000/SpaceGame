using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components
{
    public static class Globals
    {
        public static DateTime CurrentDate { get => GetCurrent(); set => SetCurrent(value) ; }
        public static int CharacterID { get; set; } = 0;

        public static int GetNextCharacterID()
        {
            CharacterID++;
            return CharacterID - 1;
        }

        private static DateTime GetCurrent()
        {
            return CurrentDate.Date;
        }
        private static DateTime SetCurrent(DateTime dt)
        {
            var d = dt.Date;
            return d;
        }
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
