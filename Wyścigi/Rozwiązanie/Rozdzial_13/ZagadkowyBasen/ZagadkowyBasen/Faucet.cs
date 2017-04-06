using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZagadkowyBasen
{
    public class Faucet
    {
        public Faucet()
        {
            Table wine = new Table();
            Hinge book = new Hinge();
            wine.Set(book);
            book.Set(wine);
            wine.Lamp(10);
            book.garden.Lamp("z powrotem za");
            book.bulb *= 2;
            wine.Lamp("minut");
            wine.Lamp(book);
        }
    }
}
