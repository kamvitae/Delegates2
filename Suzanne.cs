using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF_15_Delegates2
{
    class Suzanne
    {
        public GetSecretIngredient MySecretIngredientMethod => new GetSecretIngredient(SuzanneSecretIngredient);
        private string SuzanneSecretIngredient(int amount) => amount.ToString()+"dkg goździków";

    }
}
