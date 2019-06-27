using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop_MVC_.MODEL
{
   public class Cliente:Pessoa
    {
        public string email;

        public override string ToString()
        {
            return Cod.ToString();
        }

    }

}

