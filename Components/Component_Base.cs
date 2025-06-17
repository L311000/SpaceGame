using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components
{
    public abstract class Component_Base
    {
        public long ID { get; set; }
        public bool Enabled { get; set; }
    }
}
