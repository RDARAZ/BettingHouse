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
    class EquatableGuyWithOverload : EquatableGuy
    {
        public EquatableGuyWithOverload(string name, int age, int cash)
            : base(name, age, cash) { }
        public static bool operator ==(EquatableGuyWithOverload left,
        EquatableGuyWithOverload right)
        {
            if (Object.ReferenceEquals(left, null)) return false;
            else return left.Equals(right);
        }
        public static bool operator !=(EquatableGuyWithOverload left,
        EquatableGuyWithOverload right)
        {
            return !(left == right);
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
