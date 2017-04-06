using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pozostalosci_7
{
    class GuyCollection : IEnumerable<Guy>
    {
        private static readonly Dictionary<string, int> namesAndAges = new Dictionary<string, int>()
    {
            {"Jurek", 41}, {"Bartek", 43}, {"Edek", 39}, {"Lech", 44}, {"Franek", 45}
    };
        public IEnumerator<Guy> GetEnumerator()
        {
            Random random = new Random();
            int pileOfCash = 125 * namesAndAges.Count;
            int count = 0;
            foreach (string name in namesAndAges.Keys)
            {
                int cashForGuy = (++count < namesAndAges.Count) ? random.Next(125) : pileOfCash;
                pileOfCash -= cashForGuy;
                yield return new Guy(name, namesAndAges[name], cashForGuy);
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        /// <summary>
        /// Indeksator pobiera lub ustawia wiek faceta
        /// </summary>
        /// <param name="name">Imię faceta</param>
        /// <returns>Wiek faceta</returns>
        public int this[string name]
        {
            get
            {
                if (namesAndAges.ContainsKey(name))
                    return namesAndAges[name];
                throw new IndexOutOfRangeException("Nie znaleziono faceta o imieniu " + name);
            }
            set
            {
                if (namesAndAges.ContainsKey(name))
                    namesAndAges[name] = value;
                else
                    namesAndAges.Add(name, value);
            }
        }
    }
}