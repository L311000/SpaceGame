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
        public Game_Date CurrentDate { get => GetCurrent(); set => SetCurrent(value); }
        public Game_Date? EndDate { get; set; }
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

        public Game_Date GetCurrent()
        {
            return CurrentDate;
        }

        public void SetCurrent(Game_Date gd)
        {
            CurrentDate = gd;
        }

        public void OnAction_Date_Changed()
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
