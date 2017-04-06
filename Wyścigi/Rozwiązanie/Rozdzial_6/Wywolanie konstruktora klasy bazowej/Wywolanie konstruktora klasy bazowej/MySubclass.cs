using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wywolanie_konstruktora_klasy_bazowej
{
    class MySubclass : MyBaseClass
    {
        public MySubclass(string baseClassNeedsThis, int anotherValue)
            : base(baseClassNeedsThis)
        {
            MessageBox.Show("To jest klasa pochodna: " + baseClassNeedsThis
                 + " i " + anotherValue);
        }
    }
}
