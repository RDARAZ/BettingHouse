using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace ZabawaZJoemIBobem
{
    [Serializable]
    class Guy
    {
        public string Name;
        public int Cash;

        public int GiveCash(int amount)
        {
            if (amount <= Cash && amount > 0)
            {
                Cash -= amount;
                return amount;
            }
            else
            {
                MessageBox.Show(
                    "Nie mam wystarczającej ilości pieniędzy, aby Ci dać " + amount,
                    Name + " powiedział...");
                return 0;
            }
        }



        public int ReceiveCash(int amount)
        {
            if (amount > 0)
            {
                Cash += amount;
                return amount;
            }
            else
            {
                MessageBox.Show(amount + " to nie jest ilość pieniędzy, jaką mogę wziąć ",
                      Name + " powiedział...");
                return 0;
            }
        }

    }
}
