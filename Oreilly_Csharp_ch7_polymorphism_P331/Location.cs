using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oreilly_Csharp_ch7_polymorphism_P331
{
    abstract class Location
    {
        public string Name;
        public Location[] Exits;
        virtual public string Description { get; }
    }
}
