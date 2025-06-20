using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Graphical
{
    public class CoA_Emblem : Component_Base
    {
        public string Emblem {  get; set; }
        public Color Color1 { get; set; }
        public Color Color2 { get; set; }
        public Color Color3 { get; set; }
        public int Layer {  get; set; }
        public double X {  get; set; }
        public double Y { get; set; }
        public double Rotation { get; set; }
        public double Size { get; set; }
    }
}
