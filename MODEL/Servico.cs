using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop_MVC_.MODEL
{
   public  class Servico
    {
        private int codservico;
        private string tipo;
        private string porte;
        private decimal valor;

        public int Codservico { get => codservico; set => codservico = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Porte { get => porte; set => porte = value; }
        public decimal Valor { get => valor; set => valor = value; }

        public override string ToString()
        {
            return Codservico.ToString();
        }



    }
}
