using Components.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;

namespace Components.Characters
{
    public class Game_Character
    {
        public Localisation FirstName { get; set; }
        public List<Localisation> MiddleNames { get; set; } = [];
        public Family Family { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime? Deathdate { get; set; } = null;
        public Game_Character Father { get; set; }
        public Game_Character Mother { get; set; }
        public Game_Character Partner { get; set; }

        public double Wealth { get; set; }

        public int Age { get => GetAge(); set => SetAge(value); }

        public bool InRelationship { get => Check_InRelationship(); }
        public bool Male { get; set; }
        public bool AI { get; set; }
        public bool AI_enabled { get; set; }
        public bool Alive { get => Check_IsAlive(); }

        #region Property Methods

        #region Age
        private int GetAge()
        {
            var current = Globals.CurrentDate;
            int age = current.Year - Birthdate.Year;
            if (current < Birthdate.AddYears(age))
            {
                age--;
            }
            return age;
        }
        private void SetAge(int val)
        {
            Age = val;
        }
        #endregion
        #endregion
        #region Checks
        private bool Check_InRelationship()
        {
            if (Partner == null)
            { return false; }
            if (Partner.Deathdate >= Globals.CurrentDate)
            {
                Partner = null;
                return false;
            }
            return true;
        }

        private bool Check_IsAlive()
        {
            if (Deathdate != null)
            {
                if (Globals.CurrentDate >= Deathdate)
                {
                    return false;
                }
            }
            return true;
        }
        #endregion
    }
}
