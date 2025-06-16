using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Interface
{
    public class LocalisationCollection
    {
        public List<Localisation> Localisations { get; set; } = new List<Localisation>();
        public LocalisationLanguages Language { get; set; }
    }
}
