using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop_MVC_.MODEL
{
    public class Pessoa
    {

        private int cod;
        private string nome;
        private long cpf;
        private string cep;
        private string endereco;
        private string cidade;
        private string numero;
        private string telefone;
        private string email;

       
        public string Nome { get => nome; set => nome = value; }
        public long Cpf { get => cpf; set => cpf = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
        public int Cod { get => cod; set => cod = value; }

     




    }



}
