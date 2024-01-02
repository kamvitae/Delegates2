using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF_15_Delegates2
{
    class Amy
    {
        public GetSecretIngredient MySecretIngredientMethod => new GetSecretIngredient(AmysSecretIngredient);

        private string AmysSecretIngredient(int amount)
        {
            if (amount < 10)
                return amount.ToString() + " puszek sardynek -- potrzeba więcej";
            else
                return amount.ToString() + " puszek sardynek";
        }
    }
}
