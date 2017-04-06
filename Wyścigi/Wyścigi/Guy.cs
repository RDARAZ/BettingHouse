using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wyścigi
{
    public class Guy
    {
        public String Name;                 //Imię faceta
        public Bet MyBet;                   //Instancja klasy Bet przechowująca dane o zakładzie
        public int Cash;                    //Jak dużo pieniędzy posiada

        //Ostatnie dwa pola są kontrolkami GUI na formularzu
        public RadioButton MyRadioButton;   //Moje pole wyboru
        public Label MyLabel;               //Moja etykieta

        public void UpdateLabels()
        {
            //Ustaw moje pole tekstowe na opis zakładu, a napis obok
            //pola wyboru tak, aby pokazywał ilość pieniędzy ("Janek ma 43 zł")
            MyLabel.Text = this.MyBet.GetDescription();
        }

        public void ClearBet()              //Wyczyść mój zakład, aby był równy zero
        {

        }

        public bool PlaceBet(int amount, int DogToWin)
        {
            //Ustal nowy zakład i przechowaj go w polu MyBet
            //Zwróc true, jeżeli facet ma wystarczającą ilość pieniędzy, aby obstawić
            if (this.Cash > amount)
            {
                MyBet = new Bet()
                {
                    Amount = amount,
                    Dog = DogToWin,
                    Bettor = this
                };
                UpdateLabels();
                Console.WriteLine(this.Name + " ma wystarczająco dużo pieniędzy żeby obstawić");
                return true;
            }
            else
            {
                Console.WriteLine(this.Name + " nie ma wystarczająco dużo pieniędzy");
                return false;
            }
        }

        public void Collect(int Winner)
        {
            //Poproś o wypłatę zakładu i zaktualizuj etykiety
        }

    }
}
