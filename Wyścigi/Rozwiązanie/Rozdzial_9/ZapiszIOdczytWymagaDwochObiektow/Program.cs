using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZapiszIOdczytWymagaDwochObiektow
{
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            string folder =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            StreamReader reader =
                new StreamReader(folder + @"\tajny_plan.txt");
            StreamWriter writer =
                new StreamWriter(folder + @"\e-mailDoKapitanaWspaniałego.txt");

            writer.WriteLine("To: KapitanWspanialy@obiektowo.net");
            writer.WriteLine("From: Komisarz@obiektowo.net");
            writer.WriteLine("Subject: Czy możesz ocalić świat... po raz kolejny?"); 
            writer.WriteLine();
            writer.WriteLine("Odkryliśmy plan Kanciarza:");
            while (!reader.EndOfStream)
            {
                string lineFromThePlan = reader.ReadLine();
                writer.WriteLine("Plan -> " + lineFromThePlan);
            }
            writer.WriteLine();
            writer.WriteLine("Czy możesz nam pomóc?");
            writer.Close();
            reader.Close();
        }
    }
}
