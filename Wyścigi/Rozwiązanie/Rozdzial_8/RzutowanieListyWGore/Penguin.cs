using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RzutowanieListyWGore
{
    class Penguin : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Pengwiny nie latają!");
        }
        public override string ToString()
        {
            return "Pingwin " + base.Name;
        }
    }
}
