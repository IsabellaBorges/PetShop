using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop_MVC_.MODEL;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;


namespace PetShop_MVC_.DAO
{
   public class ClienteDAO
    {
         public void Insert(Cliente cliente)
            {
                try
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "Insert into Cliente (nome, cpf, cep, endereco, cidade, numero, telefone, email) values (@nome, @cpf, @cep, @endereco, @cidade, @numero, @telefone, @email)";

                    comando.Parameters.AddWithValue("@nome", cliente.Nome);
                    comando.Parameters.AddWithValue("@cpf", cliente.Cpf);
                    comando.Parameters.AddWithValue("@cep", cliente.Cep);
                    comando.Parameters.AddWithValue("@endereco", cliente.Endereco);
                    comando.Parameters.AddWithValue("@cidade", cliente.Cidade);
                    comando.Parameters.AddWithValue("@numero", cliente.Numero);
                    comando.Parameters.AddWithValue("@telefone", cliente.Telefone);
                    comando.Parameters.AddWithValue("@email", cliente.Email);


                ConexaoBanco.CRUD(comando);
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível se conectar" + ex.Message);
                }
         }



        public void Update(Cliente cliente)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Update Cliente set nome=@nome,cpf=@cpf,cep=@cep,endereco=@endereco,cidade=@cidade,numero=@numero,telefone=@telefone,email=@email where codcli=@codcli";

                comando.Parameters.AddWithValue("@codcli", cliente.Cod);
                comando.Parameters.AddWithValue("@nome", cliente.Nome);
                comando.Parameters.AddWithValue("@cpf", cliente.Cpf);
                comando.Parameters.AddWithValue("@cep", cliente.Cep);
                comando.Parameters.AddWithValue("@endereco", cliente.Endereco);
                comando.Parameters.AddWithValue("@cidade", cliente.Cidade);
                comando.Parameters.AddWithValue("@numero", cliente.Numero);
                comando.Parameters.AddWithValue("@telefone", cliente.Telefone);
                comando.Parameters.AddWithValue("@email", cliente.Email);
                

                ConexaoBanco.CRUD(comando);
            }

            catch (Exception ex)
            {
                throw new Exception("Não foi possível Editar o Cliente" + ex.Message);
            }
        }



        public Cliente BuscaPorCod(int cod)
        {

            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select * from Cliente Where codcli=@cod";

            comando.Parameters.AddWithValue("@cod", cod);

         

            MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

            Cliente cliente = new Cliente();
            

            if (dr.HasRows)
            {
                //Preenche o objeto 
                dr.Read();

                cliente.Cod= (int)dr["codcli"];
                cliente.Nome = (string)dr["nome"];
                cliente.Cpf = (long)dr["cpf"];
                cliente.Cep = (string)dr["cep"];
                cliente.Endereco = (string)dr["endereco"];
                cliente.Cidade = (string)dr["cidade"];
                cliente.Numero=(string)dr["numero"];
                cliente.Telefone = (string)dr["telefone"];
                cliente.Email = (string)dr["email"];


            }

            else
            {
                //zera o objeto
                cliente.Cod = 0;
                cliente.Nome ="";
                cliente.Cpf = 0;
                cliente.Cep ="";
                cliente.Endereco = "";
                cliente.Cidade = "";
                cliente.Numero = "";
                cliente.Telefone = "";
                cliente.Email ="";
               


            }
            return cliente;



        }





    }
}





