using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace UtworzmyKilkaInstancji
{
    class Clown
    {
        public string Name;
        public int Height;

        public void TalkAboutYourself()
        {
            MessageBox.Show("Nazywam się "
               + Name + " i mam "
               + Height + " centymetrów wzrostu.");
        }
    }
}
