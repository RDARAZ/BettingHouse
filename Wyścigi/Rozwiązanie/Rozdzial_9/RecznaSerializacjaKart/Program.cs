using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecznaSerializacjaKart
{
    using System.IO;
    using System.Runtime.Serialization.Formatters.Binary;

    class Program
    {
        static void Main(string[] args)
        {
            Card threeOfClubs = new Card(Suits.Clubs, Values.Three);
            using (Stream output = File.Create("karta1.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(output, threeOfClubs);
            }

            Card sixOfHearts = new Card(Suits.Hearts, Values.Six);
            using (Stream output = File.Create("karta2.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(output, sixOfHearts);
            }

            byte[] firstFile = File.ReadAllBytes("karta1.dat");
            byte[] secondFile = File.ReadAllBytes("karta2.dat");
            for (int i = 0; i < firstFile.Length; i++)
                if (firstFile[i] != secondFile[i])
                    Console.WriteLine("Bajt numer {0}: {1} i {2}",
                        i, firstFile[i], secondFile[i]);

            firstFile[307] = (byte)Suits.Spades;
            firstFile[364] = (byte)Values.King;
            File.Delete("karta3.dat");
            File.WriteAllBytes("karta3.dat", firstFile);

            using (Stream input = File.OpenRead("karta3.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                Card kingOfSpades = (Card)bf.Deserialize(input);
                Console.WriteLine(kingOfSpades);
            }

            Console.ReadKey();
        }
    }
}
