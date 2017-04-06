using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagnesikiStreamWriter
{
    using System.IO; 

    class Program
    {
        static void Main(string[] args)
        {
            Flobbo f = new Flobbo("niebiesko-żółta");
            StreamWriter sw = f.Snobbo();
            f.Blobbo(f.Blobbo(f.Blobbo(sw), sw), sw);
        }
    }
}
