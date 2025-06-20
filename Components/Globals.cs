using Components.Logic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Navigation;

namespace Components
{
    public static class Globals
    {
        public static SessionSettings Settings_Game { get; set; }
        public static Colors Colors { get; set; }
        public static string ToStringNN(this object o)
        {
            if (o == null)
            {
                return "";
            }
            var t = o.ToString();
            if (t == null)
            {
                return "";
            }
            return t;
        }

        public void Init()
        {
            var i = new Initialiser();
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

    public enum RelationshipStatus
    {
        Single, InRelationship, Married, Unable
    }

    public class Game_Date
    {
        private DateTime _date;
        public int Year { get => Get_Year(); }
        public int Month { get => Get_Month(); }
        public int Day { get => Get_Day(); }
        public string DateText { get => Get_DateTextFormat(); }
        #region Get
        private int Get_Day()
        {
            return _date.Day;
        }
        private int Get_Month()
        {
            return _date.Month;
        }
        private int Get_Year()
        {
            return _date.Year;
        }

        private string Get_DateTextFormat()
        {
            string date = "";
            if (Day < 10)
            {
                date += "0";
            }
            date += Day + ":";
            if (Month < 10)
            {
                date += "0";
            }
            date += Month + ":";
            date += Year;
            return date;
        }
        #endregion

        #region Date Manipulation
        public void AddDays(int amount = 1)
        {
            _date = _date.AddDays(amount);
            Globals.Settings_Game.OnAction_Date_Changed();
        }

        public void AddMonths(int amount = 1)
        {
            _date = _date.AddMonths(amount);
            Globals.Settings_Game.OnAction_Date_Changed();
        }

        public void AddYears(int amount = 1)
        {
            _date = _date.AddYears(amount);
            Globals.Settings_Game.OnAction_Date_Changed();
        }
        #endregion
    }
}
