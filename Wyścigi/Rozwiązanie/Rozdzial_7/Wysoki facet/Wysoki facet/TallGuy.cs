using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wysoki_facet
{
    class TallGuy : IClown
    {
        public string Name;
        public int Height;
        public void TalkAboutYourself()
        {
            Console.WriteLine("Nazywam się " + Name + " i mam "
                + Height + " centymetrów wzrostu.");
        }


        public string FunnyThingIHave
        {
            get { return "duże buty"; }
        }
        public void Honk()
        {
            Console.WriteLine("Tut tuut!");
        }

    }
}
