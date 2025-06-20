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
    public class Game_Character : Component_Base
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
        public bool HasChildren { get => Check_HasChildren();}
        public RelationshipStatus Relationship_Status_Type { get; set; }
        public bool Male { get; set; }
        public bool AI { get; set; }
        public bool AI_enabled { get; set; }
        public bool Alive { get => Check_IsAlive(); }

        #region Age
        private int GetAge()
        {
            var current = Globals.Settings_Game.CurrentDate;
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
        #region Checks
        private bool Check_InRelationship()
        {
            if (Partner == null)
            { return false; }
            if (Partner.Deathdate >= Globals.Settings_Game.CurrentDate)
            {
                Partner = null;
                return false;
            }
            if (Relationship_Status_Type == RelationshipStatus.Single || Relationship_Status_Type == RelationshipStatus.Unable)
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
                if (Globals.Settings_Game.CurrentDate >= Deathdate)
                {
                    return false;
                }
            }
            return true;
        }

        private bool Check_HasChildren()
        {
            foreach (var c in Family.Characters)
            {
                if (c.Father == this || c.Mother == this)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion

        public List<Game_Character> GetChildren(bool onlyAlive)
        {
            var l = new List<Game_Character>();
            foreach (var c in Family.Characters)
            {
                if (c.Father == this || c.Mother == this)
                {
                    if (onlyAlive)
                    {
                        if (c.Alive)
                        {
                            l.Add(c);
                        }
                    }
                    else
                    {
                        l.Add(c);
                    }
                }
            }
            return l;
        }
    }
}
