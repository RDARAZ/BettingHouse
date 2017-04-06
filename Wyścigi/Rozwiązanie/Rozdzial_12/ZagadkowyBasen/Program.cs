using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZagadkowyBasen
{
    class Program
    {
        public static void Main()
        {
            Kangaroo joey = new Kangaroo();
            int koala = joey.Wombat(joey.Wombat(joey.Wombat(1)));
            try
            {
                Console.WriteLine((15 / koala) + " jaj na kilogram");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Witaj, bracie!");
            }
        }

    }
}
