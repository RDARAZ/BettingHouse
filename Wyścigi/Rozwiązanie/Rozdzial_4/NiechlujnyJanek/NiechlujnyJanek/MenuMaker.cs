using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiechlujnyJanek
{
    class MenuMaker
    {
        public Random Randomizer;

        string[] Meats = { "Pieczona wołowina", "Salami", "Indyk", 
                             "Szynka", "Karkówka" };
        string[] Condiments = { "żółta musztarda", "brązowa musztarda", 
                                  "musztarda miodowa", "majonez", "przyprawa", "sos francuski" };
        string[] Breads = { "chleb ryżowy", "chleb biały", "chleb zbożowy", 
                              "pumpernikiel", "chleb włoski", "bułka" };

        public string GetMenuItem()
        {
            string randomMeat = Meats[Randomizer.Next(Meats.Length)];
            string randomCondiment = Condiments[Randomizer.Next(Condiments.Length)];
            string randomBread = Breads[Randomizer.Next(Breads.Length)];
            return randomMeat + ", " + randomCondiment + ", " + randomBread;
        }

    }
}
