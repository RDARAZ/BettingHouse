using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiesIPsowate
{
    class Program
    {
        static void Main(string[] args)
        {
            Canine spot = new Canine("Burek", "mops");
            Canine bob = spot;
            bob.Name = "Szarik";
            bob.Breed = "beagle";
            spot.Speak();
            Dog jake = new Dog("Tofik", "pudel");
            Dog betty = jake;
            betty.Name = "Becia";
            betty.Breed = "pit bull";
            jake.Speak();
            Console.ReadKey();
        }
    }
}
