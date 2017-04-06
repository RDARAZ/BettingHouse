using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pozostalosci_5
{
    class Program
    {
        class NestedClass
        {
            public class DoubleNestedClass
            {
                // Zawartość klasy zagnieżdżonej...
            }
        }
        static void Main(string[] args)
        {
            Type guyType = typeof(Guy);
            Console.WriteLine("{0} rozszerza {1}",
                guyType.FullName,
                guyType.BaseType.FullName);
            // wyniki: TypeExamples.Guy rozszerza System.Object

            Type nestedClassType = typeof(NestedClass.DoubleNestedClass);
            Console.WriteLine(nestedClassType.FullName);
            // wyniki: TypeExamples.Program+NestedClass+DoubleNestedClass

            List<Guy> guyList = new List<Guy>();
            Console.WriteLine(guyList.GetType().Name);
            // wyniki: List`1

            Dictionary<string, Guy> guyDictionary = new Dictionary<string, Guy>();
            Console.WriteLine(guyDictionary.GetType().Name);
            // wyniki: Dictionary`2

            Type t = typeof(Program);
            Console.WriteLine(t.FullName);
            // wyniki: TypeExamples.Program

            Type intType = typeof(int);
            Type int32Type = typeof(Int32);
            Console.WriteLine("{0} - {1}", intType.FullName, int32Type.FullName);
            // System.Int32 - System.Int32

            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            // wyniki: -3.402823E+38 3.402823E+38

            Console.WriteLine("{0} {1}", int.MinValue, int.MaxValue);
            // wyniki: -2147483648 2147483647

            Console.WriteLine("{0} {1}", DateTime.MinValue, DateTime.MaxValue);
            // wyniki: 1/1/0001 12:00:00 AM 12/31/9999 11:59:59 PM

            Console.WriteLine(12345.GetType().FullName);
            // wyniki: System.Int32

            Console.ReadKey();
        }
    }
}
