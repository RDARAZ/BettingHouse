using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przerazajacy_klown
{
    class Program
    {
        static void Main(string[] args)
        {
            ScaryScary fingersTheClown = new ScaryScary("duże buty", 14);
            FunnyFunny someFunnyClown = fingersTheClown;
            IScaryClown someOtherScaryclown = someFunnyClown as ScaryScary;
            someOtherScaryclown.Honk();
            Console.ReadKey();
        }
    }
}
