﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WartosciAReferencje
{
    class Program
    {
        static void Main(string[] args)
        {
            int howMany = 25;
            bool Scary = true;
            List<double> temperatures = new List<double>();
            Exception ex = new Exception("Nie da się obliczyć.");

            int fifteenMore = howMany;
            fifteenMore += 15;
            Console.WriteLine("howMany ma {0}, fifteenMore ma {1}",
                              howMany, fifteenMore);

            temperatures.Add(56.5D);
            temperatures.Add(27.4D);
            List<double> differentList = temperatures;
            differentList.Add(62.9D);

            Console.WriteLine("temperatures ma {0}, differentlist ma {1}",
            temperatures.Count(), differentList.Count());
        }
    }
}
