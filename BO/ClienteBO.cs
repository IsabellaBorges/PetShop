using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop_MVC_.DAO;
using PetShop_MVC_.MODEL;

namespace PetShop_MVC_.BO
{
    public class ClienteBO
    {
        public void Gravar(Cliente cliente)
        {

            ClienteDAO clienteDAO = new ClienteDAO();
            if ((cliente.Nome != "") && (cliente.Cpf != 0) && (cliente.Telefone != ""))
            {
                clienteDAO.Insert(cliente);
            }

        }


        public void Editar(Cliente cliente)
        {
            ClienteDAO clienteDAO = new ClienteDAO();
            if (cliente.Nome != "")
            {
                clienteDAO.Update(cliente);

            }
        }
        public void BuscaPorCod(Cliente cliente)
            {
                ClienteDAO clienteDao = new ClienteDAO();



                if (cliente.Cod > 0)
                {
                    var clienteTemp = clienteDao.BuscaPorCod(cliente.Cod);

                    cliente.Nome = clienteTemp.Nome;
                    cliente.Cpf = clienteTemp.Cpf;
                    cliente.Cep = clienteTemp.Cep;
                    cliente.Endereco = clienteTemp.Endereco;
                    cliente.Numero = clienteTemp.Numero;
                    cliente.Cidade = clienteTemp.Cidade;
                    cliente.Email = clienteTemp.Email;
                    cliente.Telefone = clienteTemp.Telefone;


                }
            }


}   }   