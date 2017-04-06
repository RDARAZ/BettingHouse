using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposeKontraFinalizatory
{
    using System.Windows.Forms;

    class Clone : IDisposable
    {
        public int Id { get; private set; }

        public Clone(int Id)
        {
            this.Id = Id;
        }

        public void Dispose()
        {
            MessageBox.Show("Zostałem usunięty!",
                       "Klon " + Id + ". mówi...");
        }

        ~Clone()
        {
            MessageBox.Show("Aaaaaa! Dopadłeś mnie!",
                       "Klon " + Id + ". mówi...");
        }
    }

}
