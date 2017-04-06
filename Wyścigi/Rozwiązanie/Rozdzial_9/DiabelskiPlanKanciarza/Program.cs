using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabelskiPlanKanciarza
{
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            // Zapisywanie plików w katalogu głównym nie jest zapewne dobrym pomysłem,
            // a używany system operacyjny może nawet na to nie pozwalać. Wybierz zatem
            // inny katalog, w którym będą zapisywane pliki.
            
            StreamWriter sw = new StreamWriter(@"C:\tajny_plan.txt");
            sw.WriteLine("W jaki sposób pokonać Kapitana Wspaniałego?");
            sw.WriteLine("Kolejny genialny, tajny plan Kanciarza.");
            sw.Write("Stworzę armię klonów, ");
            sw.WriteLine("uwolnię je i wystawię przeciwko mieszkańcom Obiektowa.");
            string location = "centrum handlowe";
            for (int number = 0; number <= 6; number++)
            {
                sw.WriteLine("Klon numer {0} atakuje {1}", number, location);
                if (location == "centrum handlowe") { location = "centrum miasta"; }
                else { location = "centrum handlowe"; }
            }
            sw.Close();
        }
    }
}
