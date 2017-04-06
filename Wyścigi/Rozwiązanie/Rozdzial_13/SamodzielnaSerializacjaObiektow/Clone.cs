using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamodzielnaSerializacjaObiektow
{
    using System.Windows.Forms;
    using System.IO;
    using System.Runtime.Serialization.Formatters.Binary;

    [Serializable]
    class Clone : IDisposable
    {
        public int Id { get; private set; }

        public Clone(int Id)
        {
            this.Id = Id;
        }

        public void Dispose()
        {
            string filename = @"C:\Temp\Klon.dat";
            string dirname = @"C:\Temp\";
            if (File.Exists(filename) == false)
            {
                Directory.CreateDirectory(dirname);
            }
            BinaryFormatter bf = new BinaryFormatter();
            using (Stream output = File.OpenWrite(filename))
            {
                bf.Serialize(output, this);
            }
            MessageBox.Show("Zostałem usunięty!",
                            "Klon " + Id + " mówi...");
        }

        ~Clone()
        {
            MessageBox.Show("Aaaaaa! Dopadłeś mnie!",
                       "Klon " + Id + ". mówi...");
        }
    }

}
