using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pozostalosci_6
{
    /// <summary>
    /// Facet, który wie, jak porównywać się z innymi facetami
    /// </summary>
    class EquatableGuy : Guy, IEquatable<Guy>
    {

        public EquatableGuy(string name, int age, int cash)
            : base(name, age, cash) { }

        /// <summary>
        /// Porównuje ten obiekt z innym obiektem EquatableGuy
        /// </summary>
        /// <param name="other">Obiekt EquatableGuy, z którym należy się porównać</param>
        /// <returns>True, jeśli obiekty mają taką samą zawartość, false w przeciwnym przypadku</returns>
        public bool Equals(Guy other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(other.Name, Name) && other.Age == Age && other.Cash == Cash;
        }

        /// <summary>
        /// Przesłania metodę Equals i wywołuje w niej Equals(Guy).
        /// </summary>
        /// <param name="obj">Obiekt, z którym porównujemy</param>
        /// <returns>True, jeśli wartość przekazanego obiektu jest równa wartości tego obiektu</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is Guy)) return false;
            return Equals((Guy)obj);
        }


        /// <summary>
        /// Element kontraktu na przesłonięcie metody Equals jest konieczność
        /// przesłonięcia także metody GetHashCode(). Powinna ona porównywać wartości
        /// i zwrócić true, jeśli są one sobe równe.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            const int prime = 397;
            int result = Age;
            result = (result * prime) ^ (Name != null ? Name.GetHashCode() : 0);
            result = (result * prime) ^ Cash;
            return result;
        }
    }
}
