using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Graphical
{
    public class CoA_Information : Component_Base
    {
        public string Background { get; set; }
        public Color Background_Color1 { get; set; }
        public Color Background_Color2 { get; set; }
        public Color Background_Color3 { get; set; }
        public Color Background_Color4 { get; set; }

        public List<CoA_Emblem> Emblems { get; set; } = new();
    }
}
