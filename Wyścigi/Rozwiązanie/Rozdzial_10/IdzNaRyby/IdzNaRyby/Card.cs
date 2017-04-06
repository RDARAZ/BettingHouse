using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdzNaRyby
{
    class Card
    {
        public Suits Suit { get; set; }
        public Values Value { get; set; }

        public Card(Suits suit, Values value)
        {
            this.Suit = suit;
            this.Value = value;
        }
        public string Name
        {
            get { return names[(int)Value] + " " + suits[(int)Suit]; }
        }

        public override string ToString()
        {
            return Name;
        }

        public static bool DoesCardMatch(Card cardToCheck, Suits suit)
        {
            if (cardToCheck.Suit == suit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool DoesCardMatch(Card cardToCheck, Values value)
        {
            if (cardToCheck.Value == value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static string[] names0 = new string[]
            {"", "asów", "dwójek", "trójek", "czwórek", "piątek", "szóstek", "siódemek",
             "ósemek", "dziewiątek", "dziesiątek", "waletów", "dam", "króli"};
        private static string[] names1 = new string[]
            {"", "asa", "dwójkę", "trójkę", "czwórkę", "piątkę", "szóstkę", "siódemkę",
             "ósemkę", "dziewiątkę", "dziesiątkę", "waleta", "damę", "króla"};
        private static string[] names2AndMore = new string[]
            {"", "asy", "dwójki", "trójki", "czwórki", "piątki", "szóstki", "siódemki",
             "ósemki", "dziewiątki", "dziesiątki", "walety", "damy", "króle"};

        public static string Plural(Values value, int count)
        {
            if (count == 0)
                return names0[(int)value];
            if (count == 1)
                return names1[(int)value];
            return names2AndMore[(int)value];
        }

        private static string[] suits = new string[] { "pik", "trefl", "karo", "kier" };
        private static string[] names = new string[]
            {"", "As", "Dwójka", "Trójka", "Czwórka", "Piątka", "Szóstka", "Siódemka",
             "Ósemka", "Dziewiątka", "Dziesiątka", "Walet", "Dama", "Król"};

    }

}
