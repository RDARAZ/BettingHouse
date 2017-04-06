using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZagadkowyBasen
{
    public class Hinge
    {
        public int bulb;
        public Table garden;
        public void Set(Table a)
        {
            garden = a;
        }
        public string Table()
        {
            return garden.stairs;
        }
    }
}
