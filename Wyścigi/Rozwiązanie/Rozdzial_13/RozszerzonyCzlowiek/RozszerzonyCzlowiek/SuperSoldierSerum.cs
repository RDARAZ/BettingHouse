using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RozszerzonyCzlowiek
{
    static class SuperSoldierSerum
    {
        public static string BreakWalls(this OrdinaryHuman h, double wallDensity)
        {
            return ("Przedzieram się przez ściany o gęstości " + wallDensity + ".");
        }
    }
}
