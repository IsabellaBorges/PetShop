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
    public class ServicoDAO
    {
        public void Insert(Servico servico)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Insert into Servico (codserv,tipo, porte, valor) values (@codserv,@tipo, @porte, @valor)";

                comando.Parameters.AddWithValue("@codserv", servico.Codservico);
                comando.Parameters.AddWithValue("@tipo", servico.Tipo);
                comando.Parameters.AddWithValue("@porte", servico.Porte);
                comando.Parameters.AddWithValue("@valor", servico.Valor);


                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }
        }



        public void Update(Servico servico)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Update Servico set tipo=@tipo, porte=@porte, valor=@valor where codserv=@codserv";
        

                comando.Parameters.AddWithValue("@codserv", servico.Codservico);
                comando.Parameters.AddWithValue("@tipo", servico.Tipo);
                comando.Parameters.AddWithValue("@porte", servico.Porte);
                comando.Parameters.AddWithValue("@valor", servico.Valor);


                ConexaoBanco.CRUD(comando);
            }

            catch (Exception ex)
            {
                throw new Exception("Não foi possível Editar o Servico" + ex.Message);
            }
        }



        //public Servico BuscaPorCod(int Codservico)
        //{

        //    MySqlCommand comando = new MySqlCommand();
        //    comando.CommandType = CommandType.Text;
        //    comando.CommandText = "Select *from Servico Where codserv=@codserv";

        //    comando.Parameters.AddWithValue("@codserv", Codservico);

        //    //MySqldataReader retorna uma tabela do BD

        //    MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

        //    Servico servico = new Servico();
        //    ServicoDAO servicoDAO = new ServicoDAO();


        //    if (dr.HasRows)
        //    {
        //        //Preenche o objeto 
        //        dr.Read();
        //        servico.Codservico = (int)dr["codserv"];
        //        servico.Tipo = (string)dr["tipo"];
        //        servico.Porte = (string)dr["porte"];
        //        servico.Valor = (decimal)dr["valor"];
        //    }

        //    else
        //    {
        //        //zera o objeto
        //        servico.Codservico = 0;
        //        servico.Tipo = "";
        //        servico.Porte = "";
        //        servico.Valor = 0;



        //    }
        //    return servico;



        //}




        public IList<Servico> BuscaCod(int Codservico)
        {



            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Select *from Servico Where codserv=@codserv";

                comando.Parameters.AddWithValue("@codserv", Codservico);


                ConexaoBanco.CRUD(comando);



                MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

                //Instacia uma nova lista de Dogs
                IList<Servico> servs = new List<Servico>();

                //se dr tiver linhas preenchidas em dr

                if (dr.HasRows)

                {   //Enquanto tiver lendo o dr faça
                    while (dr.Read())
                    {
                        //instancia Pet dentro do Looping para criar um objeto para cada elemento da lista

                        Servico servico = new Servico();

                        servico.Codservico = (int)dr["codserv"];
                        servico.Tipo = (string)dr["tipo"];
                        servico.Porte = (string)dr["porte"];
                        servico.Valor = (decimal)dr["valor"];



                        servs.Add(servico);


                    }
                }

                else
                {
                    servs = null;


                }
                return servs;





            }

        }
    }
}