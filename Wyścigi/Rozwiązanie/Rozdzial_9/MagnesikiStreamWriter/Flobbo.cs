using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagnesikiStreamWriter
{
    using System.IO;

    class Flobbo
    {

        private string zap;
        public Flobbo(string zap)
        {
            this.zap = zap;
        }

        public StreamWriter Snobbo()
        {

            return new
               StreamWriter("ara.txt");

        }


        public bool Blobbo(StreamWriter sw)
        {

            sw.WriteLine(zap);
            zap = "zielono-purpurowa";
            return false;

        }


        public bool Blobbo
    (bool Already, StreamWriter sw)
        {

            if (Already)
            {

                sw.WriteLine(zap);
                sw.Close();
                return false;

            }
            else
            {

                sw.WriteLine(zap);
                zap = "czerwono-pomarańczowa";
                return true;

            }

        }


    }
}
