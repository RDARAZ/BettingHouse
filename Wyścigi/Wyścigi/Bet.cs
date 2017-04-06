using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wyścigi
{
    public class Bet
    {
        public int Amount;                  //Ilość postawionych pieniędzy
        public int Dog;                     //Numer psa, na którego postawiono
        public Guy Bettor;                  //Facet który zawarł zakład

        public string GetDescription()
        {
            //Zwraca string, który określa, kto obstawił wyścig, jak dużo pieniędzy
            //postawił i na którego psa ("Janek postawił 8 zł na psa numer 4").
            //Jeżeli ilość jest równa zero, zakład nie został zawarty
            //("Janek nie zawarł zakładu")
            string description = Bettor.Name + " postawił " + this.Amount + " zł na psa nr " + (this.Dog + 1);
            return description;
        }

        public int PayOut(int Winner)
        {
            //Parametrem jest zwyciezca wyścigu. Jeżeli pies wygrał,
            //zwróć wartość postawioną. W przeciwnym razie zwróć wartość
            //postawioną ze znakiem minus
            if (Winner == this.Dog)
            {
                return this.Amount;
            }
            else
            {
                return -1 * this.Amount;
            }

        }
    }
}
