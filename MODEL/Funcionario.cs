using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop_MVC_.MODEL
{
    public class Funcionario:Pessoa
    {
        private string cartTrab;
        private decimal salario;
        private decimal salariofinal;
        

        public string CartTrab { get => cartTrab; set => cartTrab = value; }
        public decimal Salario { get => salario; set => salario = value; }
        public decimal Salariofinal { get => salariofinal; set => salariofinal = value; }

        public override string ToString()
        {
            return Cod.ToString();
        }


    }


}
