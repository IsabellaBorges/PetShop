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
   public class FuncionarioDAO
    {

        public void Insert(Funcionario funcionario)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Insert into Funcionario (nome, cpf, cep, endereco, cidade, numero, telefone, carttrab,salario) values (@nome, @cpf, @cep, @endereco, @cidade, @numero, @telefone,@carttrab,@salario)";

                comando.Parameters.AddWithValue("@nome", funcionario.Nome);
                comando.Parameters.AddWithValue("@cpf", funcionario.Cpf);
                comando.Parameters.AddWithValue("@cep", funcionario.Cep);
                comando.Parameters.AddWithValue("@endereco", funcionario.Endereco);
                comando.Parameters.AddWithValue("@cidade", funcionario.Cidade);
                comando.Parameters.AddWithValue("@numero", funcionario.Numero);
                comando.Parameters.AddWithValue("@telefone", funcionario.Telefone);               
                comando.Parameters.AddWithValue("@carttrab", funcionario.CartTrab);
                comando.Parameters.AddWithValue("@salario", funcionario.Salario);


                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }
        }



        public void Update(Funcionario funcionario)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Update Funcionario set nome=@nome,cpf=@cpf,cep=@cep,endereco=@endereco,cidade=@cidade,numero=@numero,telefone=@telefone,carttrab=@carttrab,salario=@salario where codfunc=@codfunc";

                comando.Parameters.AddWithValue("@codfunc", funcionario.Cod);
                comando.Parameters.AddWithValue("@nome", funcionario.Nome);
                comando.Parameters.AddWithValue("@cpf", funcionario.Cpf);
                comando.Parameters.AddWithValue("@cep", funcionario.Cep);
                comando.Parameters.AddWithValue("@endereco", funcionario.Endereco);
                comando.Parameters.AddWithValue("@cidade", funcionario.Cidade);
                comando.Parameters.AddWithValue("@numero", funcionario.Numero);
                comando.Parameters.AddWithValue("@telefone", funcionario.Telefone);
                comando.Parameters.AddWithValue("@carttrab", funcionario.CartTrab);
                comando.Parameters.AddWithValue("@salario", funcionario.Salario);


                ConexaoBanco.CRUD(comando);
            }

            catch (Exception ex)
            {
                throw new Exception("Não foi possível Editar o funcionario" + ex.Message);
            }
        }


        public Funcionario BuscaPorCod(int cod)
        {

            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select *from Funcionario Where codfunc=@codfunc";

            comando.Parameters.AddWithValue("@codfunc", cod);

            //MySqldataReader retorna uma tabela do BD

            MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

            Funcionario fun = new Funcionario();//Instancia para poder retornar um valor
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();//Instacia para retornar os dados de Autor
            //se dr tiver linhas preenchidas

            if (dr.HasRows)
            {
                //Preenche o objeto 
                dr.Read();
                fun.Cod = (int)dr["codfunc"];
                fun.Nome = (string)dr["nome"];
                fun.Cpf = (long)dr["cpf"];
                fun.Cep = (string)dr["cep"];
                fun.Endereco = (string)dr["endereco"];
                fun.Cidade = (string)dr["cidade"];
                fun.Numero = (string)dr["numero"];
                fun.Telefone = (string)dr["telefone"];
                fun.Salario = (decimal)dr["salario"];
                fun.CartTrab = (string)dr["carttrab"];


            }

            else
            {
                //zera o objeto
                fun.Cod = 0;
                fun.Nome = "";
                fun.Cpf = 0;
                fun.Cep = "";
                fun.Endereco = "";
                fun.Cidade = "";
                fun.Numero = "";
                fun.Telefone = "";
                fun.Salario = 0;
                fun.CartTrab = "";




            }
            return fun;



        }

        public Funcionario CalculaSalario(Funcionario funcionario)
        {

            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = " SELECT funcionario.CODFUNC,funcionario.SALARIO * 0.1 * (SELECT COUNT(*) FROM atendimento WHERE atendimento.CODFUNC = funcionario.CODFUNC) COMISSAO FROM funcionario where funcionario.codfunc=@codfunc";

            comando.Parameters.AddWithValue("@codfunc", funcionario.Cod);

            
            

            MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

           

            Funcionario fun = new Funcionario();
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
            

            if (dr.HasRows)
            {
                //Preenche o objeto 
                dr.Read();

                fun.Salariofinal= (decimal)dr["comissao"];
                



            }

            else
            {
                //zera o objeto
                fun.Salario = 0;




            }
            return fun;



        }


    }

}
