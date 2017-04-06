using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TajneSkladniki
{
    class Amy
    {
        public GetSecretIngredient AmysSecretIngredientMethod
        {
            get
            {
                return new GetSecretIngredient(AmysSecretIngredient);
            }
        }
        private string AmysSecretIngredient(int amount)
        {
            if (amount < 10)
                return amount.ToString()
                            + " puszek sardynek -- potrzebujesz więcej!";
            else
                return amount.ToString() + " puszek sardynek";
        }
    }
}
