using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pozostalosci_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zawartość kolekcji SportCollection:");
            SportCollection sportCollection = new SportCollection();
            foreach (Sport sport in sportCollection)
                Console.WriteLine(sport.ToString());


            IEnumerable<string> names = NameEnumerator(); // Tu umieść punkt przerwania
            foreach (string name in names)
                Console.WriteLine(name);

            Console.WriteLine(sportCollection[3]);

            GuyCollection guyCollection = new GuyCollection();
            Console.WriteLine("Dodanie dwóch facetów i modyfikacja kolejnego");
            guyCollection["Bartek"] = guyCollection["Jurek"] + 3;
            guyCollection["Bolek"] = 57;
            guyCollection["Henryk"] = 31;
            foreach (Guy guy in guyCollection)
                Console.WriteLine(guy.ToString());

            Console.ReadKey();
        }

        static IEnumerable<string> NameEnumerator()
        {
            yield return "Bartek";   // Metoda kończy działanie po tej instrukcji ...
            yield return "Henryk";   // ...a po ponownym uruchomieniu zaczyna od tego miejsca.
            yield return "Jurek";
            yield return "Franek";
        }
    }
}
