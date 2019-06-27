using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop_MVC_.MODEL
{
    public class Atendimento
    {

        private int atendimentoCod;
        private DateTime dataHora;
        private string situacao;
        private Funcionario funcionario;
        private Servico servico;
        private Pet pet;
     


        public int AtendimentoCod { get => atendimentoCod; set => atendimentoCod = value; }
        public DateTime DataHora { get => dataHora; set => dataHora = value; }
        public string Situacao { get => situacao; set => situacao = value; }
        public Funcionario Funcionario { get => funcionario; set => funcionario = value; }
        public Servico Servico { get => servico; set => servico = value; }
        public Pet Pet { get => pet; set => pet = value; }
       

        public Atendimento()
         {

             Funcionario = new Funcionario();
             Servico = new Servico();
             Pet = new Pet();
         
         }


        
       

    }


}
