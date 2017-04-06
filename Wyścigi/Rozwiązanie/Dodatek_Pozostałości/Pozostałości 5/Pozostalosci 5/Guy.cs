using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pozostalosci_5
{
    /// <summary>
    /// Facet - o jakimś imieniu (name), wieku (age) i z portfelem pełnym kasy
    /// </summary>
    class Guy
    {
        /*
         * Zwróć uwagę, że Name i Age są właściwościami, którym towarzyszą pola wenętrzne
         * przeznaczone tylko do odczytu. Zastosowanie modyfikatora readolny oznacza,
         * że wartość tych pól może być określona wyłącznie w momencie inicjalizacji
         * obiektu (w ich deklaracji lub w konstruktorze).
         */

        /// <summary>
        /// Wewnętrzne pole tylko do odczytu dal właściwości Name
        /// </summary>
        private readonly string name;

        /// <summary>
        /// Imię faceta
        /// </summary>
        public string Name { get { return name; } }

        /// <summary>
        /// Wewnętrzne pole tylko do odczytu dla właściwości Age
        /// </summary>
        private readonly int age;

        /// <summary>
        /// Wiek gościa
        /// </summary>
        public int Age { get { return age; } }

        /*
         * Właściwość Cash nie jest tylko do odczytu, gdyż jej wartość może się zmieniać
         * podczas istnienia obiektu Guy.
         */

        /// <summary>
        /// Ilość gotówki w posiadaniu faceta
        /// </summary>
        public int Cash { get; private set; }

        /// <summary>
        /// Konstruktor ustawia imię, wiek i posiadaną gotówkę.
        /// </summary>
        /// <param name="name">Imię faceta</param>
        /// <param name="age">Wiek faceta</param>
        /// <param name="cash">Początkowa ilość gotówki</param>
        public Guy(string name, int age, int cash)
        {
            this.name = name;
            this.age = age;
            Cash = cash;
        }

        public override string ToString()
        {
            return String.Format("{0} ma {1} lat i {2} zł gotówki.", Name, Age, Cash);
        }

        /// <summary>
        /// Bierze facetowi pieniądze z portfela.
        /// </summary>
        /// <param name="amount">Odbierana kwota pieniędzy</param>
        /// <returns>Wielkość oddawanej kwoty lub 0, jeśli facet nie ma wystarczająco dużo gotówki</returns>
        public int GiveCash(int amount)
        {
            if (amount <= Cash && amount > 0)
            {
                Cash -= amount;
                return amount;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Dodaje gotówkę do portfela faceta.
        /// </summary>
        /// <param name="amount">Otrzymana kwota</param>
        /// <returns>Wysokość otrzymanej kwoty lub 0, jeśli facet nic nie otrzymał</returns>
        public int ReceiveCash(int amount)
        {
            if (amount > 0)
            {
                if (amount > 0)
                {
                    Cash += amount;
                    return amount;
                }
                Console.WriteLine("{0} mówi: {1} nie jest kwotą, jaką bym przyjął.", Name, amount);
            }
            return 0;
        }
    }
}
