using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiesIPsowate
{
    public class Canine
    {
        public string Name;
        public string Breed;

        public Canine(string name, string breed)
        {
            this.Name = name;
            this.Breed = breed;
        }

        public void Speak()
        {
            Console.WriteLine("Wabię się {0}. Moja rasa to {1}.", Name, Breed);
        }
    }
}
