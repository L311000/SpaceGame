using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Interface
{
    public class Localisation : Component_Base
    {
        public string Name { get; set; }
        public int Priority { get; set; }
        public string Text { get; set; }
        public bool Custom { get; set; }

        #region Konstruktoren
        public Localisation() { }
        public Localisation(string name)
        {
            Name = name;
            Priority = 0;
            Text = "";
        }
        public Localisation(string name, int prio)
        {
            Name = name;
            Priority = prio;
            Text = "";
        }
        public Localisation(string name, string t)
        {
            Name = name;
            Priority = 0;
            Text = t;
        }
        public Localisation(string name, string t, int prio)
        {
            Name = name;
            Priority = prio;
            Text = t;
        }
        #endregion

        public override string ToString()
        {
            return $"{Name}:{Priority} \"{Text}\"";
        }
    }
}
