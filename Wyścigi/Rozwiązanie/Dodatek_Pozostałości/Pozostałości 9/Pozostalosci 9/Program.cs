using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pozostalosci_9
{
    class Program
    {
        delegate void MyIntAndString(int i, string s);
        delegate int CombineTwoInts(int x, int y);

        static void Main(string[] args)
        {
            /*
             * W rozdziale 14. pisaliśmy, że słowo kluczowe var pozwala IDE określić typ
             * obiektu podczas kompilacji.                  
             *
             * Używając var i new, można także tworzyć obiekty o anonimowych typach.         
             *
             * Więcej informacji na temat tych typów możesz znaleźć na stronie         
             * http://msdn.microsoft.com/pl-pl/library/bb397696.aspx.
             */

            // Tworzymy typ anonimowy przypominający klasę Guy.
            var anonymousGuy = new { Name = "Bartek", Age = 43, Cash = 137 };

            // Kiedy będziesz wpisywał poniższą instrukcję, IntelliSense wyświetli
            // składowe - Name, Age oraz Cash.
            Console.WriteLine("{0} ma {1} lata i {2} zł gotówki.",
                anonymousGuy.Name, anonymousGuy.Age, anonymousGuy.Cash);
            // Wyniki: Bartek ma 43 lata i 137 zł gotówki.

            // Instancja typu anonimowego ma także całkiem sensowną metodę ToString().
            Console.WriteLine(anonymousGuy.ToString());
            // Wyniki: { Name = Bartek, Age = 43, Cash = 137 }

            /*
             * W rozdziale 15. dowiedziałeś się, jak używać delegatów, by tworzyć
             * referencje do metod. We wszystkich przedstawionych przykładach ich   
             * zastosowania przypisywaliśmy do nich istniejące metody.
             *                                     
             * Metody anonimowe to metody deklarowane w instrukcji - używane są przy
             * tym nawiasy klamrowe { } podobnie jak w przypadku anonimowych typów.                  
             *
             * Więcej informacji na temat anonimowych metod znajdziesz na stronie         
             * http://msdn.microsoft.com/pl-pl/library/0yw3tz5k.aspx.
             */

            // Oto metoda anonimowa, która wyświetla na konsoli liczbę i łańcuch znaków.
            // Jej deklaracja pasuje do delegata MyIntAndString (zdefiniowanego 
            // wcześniej), zatem możemy ją przypisać do zmiennej typu MyIntAndString.
            MyIntAndString printThem = delegate(int i, string s)
            { Console.WriteLine("{0} - {1}", i, s); };
            printThem(123, "cztery pięć sześć");
            // Wyniki: 123 - cztery pięć sześć

            // A tu mamy kolejną anonimową metodę o takiej samej sygnaturze (int, 
            // string). Ta metoda sprawdza, czy w łańcuchu występuje liczba.
            MyIntAndString contains = delegate(int i, string s)
            { Console.WriteLine(s.Contains(i.ToString())); };
            contains(123, "cztery pięć sześć");
            // Wynik: False

            contains(123, "cztery 123 pięć sześć");
            // Wynik: True

            // Można dynamicznie wywołać metodę, używając Delegate.DynamicInvoke()
            // i przekazując parametry wywołania w formie tablicy obiektów.
            Delegate d = contains;
            d.DynamicInvoke(new object[] { 123, "cztery 123 pięć sześć" });
            // Output: True

            /*
             * Wyrażenia lambda są specjalnym rodzajem anonimowych metod, które 
             * korzystają z operatora =>. Nosi on nazwę operatora lambda, jednak
             * w przypadku tych wyrażeń, czytając go, zazwyczaj używamy
             * określenia "przechodzi do". Oto proste wyrażenie lambda:                  
             *
             * (a, b) => { return a + b; }
             *
             * Można je przeczytać jako "a i b przechodzi do a plus b" - jest to 
             * metoda anonimowa dodająca dwie wartości. Można wyobrażać sobie wyrażenia
             * lambda jako metody anonimowe pobierające parametry i zwracające wartości.                           
             *
             * Więcej informacji na temat wyrażeń lambda znajdziesz na stronie         
             * http://msdn.microsoft.com/pl-pl/library/bb397687.aspx.
             */

            // Oto wyrażenie lambda służące do dodawania dwóch liczb. Jego sygnatura
            // odpowiada delegatowi CombineTwoInts, a zatem możesz je przypisać do 
            // zmiennej typu CombineTwoInts. Zwróć uwagę, że delegat ten zwraca 
            // wartość typu int, zatem także wyrażenie lambda musi taką zwracać.
            CombineTwoInts adder = (a, b) => { return a + b; };
            Console.WriteLine(adder(3, 5));
            // Wyniki: 8

            // A oto kolejne wyrażenie lambda - to z kolei mnoży dwie liczby:
            CombineTwoInts multiplier = (int a, int b) => { return a * b; };
            Console.WriteLine(multiplier(3, 5));
            // Wyniki: 15

            // Łącząc wyrażenia lambda z LINQ, można wykonywać naprawdę złożone 
            // operacje. Poniżej przedstawiliśmy prosty przykład.
            var greaterThan3 = new List<int> { 1, 2, 3, 4, 5, 6 }.Where(x => x > 3);
            foreach (int i in greaterThan3) Console.Write("{0} ", i);
            // Wyniki: 4 5 6 

            Console.ReadKey();
        }
    }
}