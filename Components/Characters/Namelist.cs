using Components.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Characters
{
    public class Namelist : Component_Base
    {
        public Localisation Name {  get; set; }


        public List<Localisation> First_Names_Male = new List<Localisation>();
        public List<Localisation> First_Names_Female = new List<Localisation>();
        public List<Localisation> Middle_Names_Male = new List<Localisation>();
        public List<Localisation> Middle_Names_Female = new List<Localisation>();
        public List<Localisation> Last_Names = new List<Localisation>();

        public List<Localisation> First_Names_Male_Regnal = new List<Localisation>();
        public List<Localisation> First_Names_Female_Regnal = new List<Localisation>();
        public List<Localisation> Middle_Names_Male_Regnal = new List<Localisation>();
        public List<Localisation> Middle_Names_Female_Regnal = new List<Localisation>();
        public List<Localisation> Last_Names_Regnal = new List<Localisation>();

        public List<Localisation> Ships_Generic_Names = new List<Localisation>();
        public List<Localisation> Ships_Small_Names = new List<Localisation>();
        public List<Localisation> Ships_Medium_Names = new List<Localisation>();
        public List<Localisation> Ships_Large_Names = new List<Localisation>();
        public List<Localisation> Ships_ExtraLarge_Names = new List<Localisation>();
        public List<Localisation> Ships_Gigantic_Names = new List<Localisation>();

        public List<Localisation> Planets_Generic_Names = new List<Localisation>();
    }
}
