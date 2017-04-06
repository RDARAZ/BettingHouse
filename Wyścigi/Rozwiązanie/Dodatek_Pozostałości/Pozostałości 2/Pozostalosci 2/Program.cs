using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pozostalosci_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Będziemy używali tych instancji Guy i Random w dalszej części przykładu.
            Guy bob = new Guy("Bob", 43, 100);
            Guy joe = new Guy("Joe", 41, 100);
            Random random = new Random();


            /*
             * Oto dwa przydatne słowa kluczowe używane w pętlach. Słowo "continue"
             * nakazuje rozpoczęcie następnej iteracji pętli, natomiast "break" powoduje  
             * natychmiastowe przerwanie jej wykonywania.
             *          
             * Instrukcje break, continue, throw oraz return są nazywane instrukcjami skoków,
             * gdyż ich wykonanie powoduje przeskoczenie do innego miejsca programu. (Poznałeś
             * instrukcję break wraz z instrukcją switch/case w rozdziale 8., a throw 
             * w rozdziale 10.). Istnieje jeszcze jedna instrukcja skoku - goto. Umożliwia
             * ona przeskoczenie do miejsca opatrzonego etykietą. (Na pewno poznasz te etykiety,
             * bo mają podobną składnię do tych stosowanych w instrukcji case).          
             *     
             * Poniższą pętlę bez żadnego problemu mógłbyś napisać bez używania instrukcji 
             * continue i break. Stanowi ona doskonały przykład pokazujący, jak C# pozwala zrobić
             * to samo na wiele różnych sposobów. To właśnie dlatego nie musiałeś używać
             * instrukcji break, continue ani innych słów kluczowych i operatorów do pisania
             * programów przedstawionych w tej książce.           
             * 
             * Instrukcja break jest także stosowane wraz z case, o czym mogłeś się przekonać
             * w rozdziale 8.             
             *  
             */

            while (true)
            {
                int amountToGive = random.Next(20);

                // Słowo kluczowe continue powoduje rozpoczęcie następnej iteracji pętli
                // Użyjemy go, by przekazywać Joemu jedynie kwoty
                // większe od 10 złotych.
                if (amountToGive < 10)
                    continue;

                // Słowo kluczowe break przerywa wykonywanie pętli.
                if (joe.ReceiveCash(bob.GiveCash(amountToGive)) == 0)
                    break;

                Console.WriteLine("Bob dał Joemu {0} złotych, Joe ma {1} złotych, a Bob ma {2} złotych.",
                    amountToGive, joe.Cash, bob.Cash);
            }
            Console.WriteLine("Bobowi zostało {0} złotych.", bob.Cash);

            // Operator warunkowy ? : jest odpowiednikiem instrukcji if/then/else zapisanych 
            // w jednym wyrażeniu.
            // [boolean test] ? [instrukcja wykonywana, gdy true] : [instrukcja wykonywana, gdy false]
            Console.WriteLine("Bob {0} więcej gotówki niż Joe",
                bob.Cash > joe.Cash ? "ma" : "nie ma");

            // Operator łączący null ?? sprawdza, czy podana wartość to null. Zwraca on wartość, 
            // jeśli jest ona różna od null, lub drugą z podanych wartości w przeciwnym razie.
            // [sprawdzana wartość] ?? [wartość zwracana, jeśli null]
            bob = null;
            Console.WriteLine("Wynik zwrócony przez ?? to '{0}'", bob ?? joe);

            // A oto przykład pętli używającej instrukcji goto i etykiet. Rzadko można
            // je zobaczyć, jednak w przypadku stosowania zagnieżdżonych pętli mogą się okazać 
            // przydatne. (Instrukcja break powoduje jedynie zakończenie pętli najbardziej 
            // wewnętrznej.) 
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i > 3)
                        goto afterLoop;
                    Console.WriteLine("i = {0}, j = {1}", i, j);
                }
            }
        afterLoop:



            // Kiedy używasz operatora = w przypisaniu, zwraca on wartość, której możesz następnie
            // użyć w kolejnym przypisaniu lub w instrukcji if.
            int a;
            int b = (a = 3 * 5);
            Console.WriteLine("a = {0}; b = {1};", a, b);

            // Jeśli umieścisz operator ++ przed zmienną, to najpierw zostanie ona  
            // powiększona, a dopiero potem program wykona resztę instrukcji.
            a = ++b * 10;
            Console.WriteLine("a = {0}; b = {1};", a, b);

            // Umieszczenie ++ za zmienną powoduje wykonanie instrukcji w pierwszej kolejności, 
            // a potem inkrementację zmiennej.
            a = b++ * 10;
            Console.WriteLine("a = {0}; b = {1};", a, b);


            /*
             * Używając operatorów && i || w testach logicznych, wykorzystujemy "przetwarzanie 
             * skrócone", co oznacza, że przetwarzanie warunku kończy się, gdy tylko okaże się,
             * że jego wynik jest już znany. W przypadku (A || B), jeśli A wynosi true, to całe
             * wyrażenie A || B także będzie mieć wartość true niezależnie od B.
             * W przypadku przetwarzania (A && B), jeśli A wynosi false, to całe 
             * wyrażenie także będzie mieć wartość false niezależnie od B. W obu sytuacjach 
             * B nigdy nie zostanie przetworzone, gdyż jego wartość jest niepotrzebna do 
             * podana wynikowej wartości całego wyrażenia.
             */

            int x = 0;
            int y = 10;
            int z = 20;

            // y / x spowoduje zgłoszenie wyjątku DivideByZeroException, gdyż x wynosi 0. 
            // Jednak ze względu na to, że (y < z) wynosi true, operator || wie, iż całe 
            // wyrażenie przyjmie wartość true, bez konieczności wyliczania jego drugiej części.
            // Dlatego drugi człon warunku: (y / x == 4), nigdy nie zostanie wykonany.
            if ((y < z) || (y / x == 4))
                Console.WriteLine("Wiersz pojawił się, gdyż operator || używa skróconego przetwarzania.");

            // Ponieważ (y > z) ma wartość false, operator && wie, że całe wyrażenie 
            // przyjmie wartość false, bez konieczności wyliczania drugiego członu. 
            // Dlatego nigdy nie zostanie on wykonany.
            if ((y > z) && (y / x == 4))
                Console.WriteLine("Ten wiersz nigdy nie zostanie wyświetlony, gdyż && też używa skróconego przetwarzania.");


            /*
             * Wielu z nas, myśląc o programowaniu, myśli o zerach i jedynkach, a do 
             * sprawdzania tych zer i jedynek służą operatory logiczne.
             */

            // Użyj Convert.ToString() oraz Convert.ToInt32(), by przekonwertować liczbę na łańcuch 
            // zer i jedynek lub by łańcuch zer i jedynek przekonwertować na postać binarną. 
            // Drugi argument określa, że konwertujemy na liczbę zapisaną w systemie dwójkowym.
            string binaryValue = Convert.ToString(217, 2);
            int intValue = Convert.ToInt32(binaryValue, 2);
            Console.WriteLine("Dwójkowa liczba {0} ma dziesiętną wartość {1}.", binaryValue, intValue);

            // Operatory &, |, ^ oraz ~ odpowiadają operatorom logicznym AND, OR, XOR oraz  
            // dopełnieniu bitowemu.
            int val1 = Convert.ToInt32("100000001", 2);
            int val2 = Convert.ToInt32("001010100", 2);
            int or = val1 | val2;
            int and = val1 & val2;
            int xor = val1 ^ val2;
            int not = ~val1;


            // Wyświetlamy wartości - używamy String.PadLeft(), by wyświetlić początkowe zera.
            Console.WriteLine("val1: {0}", Convert.ToString(val1, 2));
            Console.WriteLine("val2: {0}", Convert.ToString(val2, 2).PadLeft(9, '0'));
            Console.WriteLine("or: {0}", Convert.ToString(or, 2).PadLeft(9, '0'));
            Console.WriteLine("and: {0}", Convert.ToString(and, 2).PadLeft(9, '0'));
            Console.WriteLine("xor: {0}", Convert.ToString(xor, 2).PadLeft(9, '0'));
            Console.WriteLine("not: {0}", Convert.ToString(not, 2).PadLeft(9, '0'));
            // Zauważ, że operator ~ zwrócił: 11111111111111111111111011111110.
            // To 32-bitowe dopełnienie wartości zmiennej val1: 00000000000000000000000100000001.
            // Operatory logiczne operują na liczbach int, które są 32-bitowymi liczbami całkowitymi.

            // Operatory << i >> przesuwają bity w lewo i w prawo. Dowolne operatory logiczne możesz
            // połączyć z =, a więc >>= lub &= działają podobnie do += lub *=.
            int bits = Convert.ToInt32("11", 2);
            for (int i = 0; i < 5; i++)
            {
                bits <<= 2;
                Console.WriteLine(Convert.ToString(bits, 2).PadLeft(12, '0'));
            }
            for (int i = 0; i < 5; i++)
            {
                bits >>= 2;
                Console.WriteLine(Convert.ToString(bits, 2).PadLeft(12, '0'));
            }


            // Możesz utworzyć nową instancję klasy i wywołać na jej rzecz metodę bez
            // wcześniejszego przypisywania jej do zmiennej.
            Console.WriteLine(new Guy("Harry", 47, 376).ToString());


            // W książce do łączenia łańcuchów znaków używaliśmy operatora + i wszystko 
            // działało doskonale. Jednak wiele osób unika stosowania tego operatora w pętlach, 
            // które będą wielokrotnie wykonywane, gdyż każde jego użycie powoduje utworzenie na 
            // stercie nowego obiektu, który potem będzie musiał zostać usunięty. Właśnie z tego 
            // względu .NET udostępnia klasę StringBuilder, która doskonale nadaje się do 
            // efektywnego tworzenia i łączenia łańcuchów. Jej metoda Append() dodaje łańcuch na 
            // końcu, AppendFormat() dodaje łańcuch sformatowany (używając przy tym {0} oraz 
            // {1}, tak jak robią to metody String.Format() oraz Console.WriteLine()), a metoda 
            // AppendLine() dodaje linijkę ze znakiem nowego wiersza na końcu. Aby uzyskać 
            // ostateczny łańcuch wystarczy wywołać metodę ToString().
            StringBuilder stringBuilder = new StringBuilder("Cześć ");
            stringBuilder.Append("kolego, ");
            stringBuilder.AppendFormat("wita {0}-letni facet imieniem {1}. ", joe.Age, joe.Name);
            stringBuilder.AppendLine("Jakąż wspaniałą pogodę dziś mamy.");
            Console.WriteLine(stringBuilder.ToString());

            Console.ReadKey();


            /*
             * To wystarczające informacje, by zacząć programować w C#, jednak w żadnym wypadku 
             * nie są one kompletne ani wyczerpujące. Na szczęście Microsoft udostępnia 
             * dokumentację zawierającą wykaz wszystkich operatorów, słów kluczowych oraz innych 
             * cech tego języka. Przejrzyj ją - jeśli dopiero zaczynasz poznawać C#, nie przejmuj 
             * się tym, że może się ona wydawać trudna do zrozumienia. Witryna MSDN jest 
             * wspaniałym źródłem informacji, choć nie została pomyślana jako centrum do nauki.
             *
             * dokumentacja języka C#: http://msdn.microsoft.com/en-us/library/618ayhy6.aspx
             * operatory C# : http://msdn.microsoft.com/en-us/library/6a71f45d.aspx
             * słowa kluczowe C# : http://msdn.microsoft.com/en-us/library/x53a06bb.aspx
             */
        }
    }
}