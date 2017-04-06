using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RozszerzonyCzlowiek
{
    sealed class OrdinaryHuman
    {
        private int age;
        int weight;
        public OrdinaryHuman(int weight)
        {
            this.weight = weight;
        }
        public void GoToWork() { /* kod dla GoToWork */ }
        public void PayBills() { /* kod dla PayBills */ }
    }
}
