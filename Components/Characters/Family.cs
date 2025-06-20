using Components.Graphical;
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
        public Game_Character Founder { get; set; }
        public Game_Character Head { get; set; }
        public DateTime? Extinct { get; set; }

        public bool IsCadet {  get; set; }
        public Family IsCadetOfFamily { get; set; } = null;
        public bool Active { get => Check_IsActive(); }
        
        public CoA_Information CoA { get; set; }

        private bool Check_IsActive()
        {
            if (Extinct != null && Extinct > Globals.Settings_Game.CurrentDate)
            {
                return false;
            }
            return true;
        }
    }
}
