using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.TextFormatting;

namespace Components
{
    public class SessionSettings
    {
        public DateTime CurrentDate { get => GetCurrent(); set => SetCurrent(value); }
        public DateTime? EndDate { get; set; }
        public static long CharacterID_Counter { get; set; } = 0;
        public static int Age_Adult { get; set; }
        public static int Age_Teenager { get; set; }
        public static int Age_Child { get; set; }
        public bool GamePaused { get; set; }
        public Random Randomizer { get; set; } = new Random();

        public static long GetNextCharacterID()
        {
            CharacterID_Counter++;
            return CharacterID_Counter - 1;
        }

        public DateTime GetCurrent()
        {
            return CurrentDate.Date;
        }
        public DateTime SetCurrent(DateTime dt)
        {
            var d = dt.Date;
            return d;
        }

        public void AddDay()
        {
            CurrentDate = CurrentDate.AddDays(1);
        }

        public void OnAction_NewDay()
        {
            AddDay();
        }

        public void OnAction_MonthChange()
        {

        }

        public void OnAction_YearChange()
        {

        }

        public void OnAction_WarDeclaration()
        {

        }

        public void OnAction_PeaceDeclaration()
        {

        }
        public void OnAction_NewFaction()
        {

        }

        public void OnAction_FactionDestroyed()
        {

        }



    }
}
