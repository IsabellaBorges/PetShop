using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop_MVC_.DAO;
using PetShop_MVC_.MODEL;

namespace PetShop_MVC_.BO
{
    public class FuncionarioBO
    {

        public void Gravar(Funcionario funcionario)
        {
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();


             if ((funcionario.Nome != "") && (funcionario.Cpf != 0) && (funcionario.Telefone != "") && (funcionario.Cep != null))
            {
                funcionarioDAO.Insert(funcionario);
            }
            



        }
        public void Editar(Funcionario funcionario)
        {
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
            if (funcionario.Nome != "")
            {
                funcionarioDAO.Update(funcionario);
            }
        }
            public void BuscaPorCod(Funcionario funcionario)
        {
            FuncionarioDAO funcionarioDao = new FuncionarioDAO();



            if (funcionario.Cod > 0)
            {
                var funTemp = funcionarioDao.BuscaPorCod(funcionario.Cod);
                funcionario.Nome = funTemp.Nome;
                funcionario.Cpf = funTemp.Cpf;
                funcionario.Cep = funTemp.Cep;
                funcionario.Endereco = funTemp.Endereco;
                funcionario.Numero = funTemp.Numero;
                funcionario.Cidade = funTemp.Cidade;
                funcionario.CartTrab = funTemp.CartTrab;
                funcionario.Telefone = funTemp.Telefone;
                funcionario.Salario = funTemp.Salario;

            }
    }


        public void calculaSalario(Funcionario funcionario)
        {
            FuncionarioDAO funcionarioDao = new FuncionarioDAO();



            if (funcionario.Cod > 0)
            {
                var funTemp = funcionarioDao.CalculaSalario(funcionario);
                
                funcionario.Salariofinal = funTemp.Salariofinal;
               

            }
        }



    }
}