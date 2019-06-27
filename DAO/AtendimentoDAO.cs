using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop_MVC_.MODEL;
using MySql.Data; 
using MySql.Data.MySqlClient;
using System.Data;//inserir para usar o commandType

namespace PetShop_MVC_.DAO
{
    public class AtendimentoDAO
    {
        public void Insert(Atendimento atendimento)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Insert into Atendimento (codserv, codpet, codfunc, datahora, situacao) values (@codserv, @codpet, @codfunc, @datahora, @situacao)";

                comando.Parameters.AddWithValue("@codserv", atendimento.Servico.Codservico);
                comando.Parameters.AddWithValue("@codpet", atendimento.Pet.CodPet);
                comando.Parameters.AddWithValue("@codfunc", atendimento.Funcionario.Cod);
                comando.Parameters.AddWithValue("@datahora", atendimento.DataHora);
                comando.Parameters.AddWithValue("@situacao", atendimento.Situacao);


                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }
        }


        //estudar como fazer ↓

        public IList<Atendimento> BuscaPeriodo(DateTime DtInicio, DateTime DtFim)
        {


            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select * from Atendimento where datahora between @DtInicio and @DtFim";

            
            comando.Parameters.AddWithValue("@DtInicio", DtInicio);
            comando.Parameters.AddWithValue("@DtFim", DtFim);



            MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

            IList<Atendimento> atends = new List<Atendimento>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    Atendimento atendimento = new Atendimento();

                    atendimento.AtendimentoCod = (int)dr["codatend"];
                    atendimento.Servico.Codservico = (int)dr["codserv"];
                    atendimento.Pet.CodPet = (int)dr["codpet"];
                    atendimento.Funcionario.Cod = (int)dr["codfunc"];
                    atendimento.DataHora = (DateTime)dr["datahora"];
                    atendimento.Situacao = (string)dr["situacao"];

                    atends.Add(atendimento);
                }
            }

            else
            {
                atends = null;



            }
            return atends;




        }



        public IList <Atendimento> BuscaPet(int codPet)
        {

            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select *from Atendimento Where codpet=@codpet";

            comando.Parameters.AddWithValue("@codpet", codPet);

            

            MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

            IList<Atendimento> atends = new List<Atendimento>();

           
            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    Atendimento atendimento = new Atendimento();

                    atendimento.AtendimentoCod = (int)dr["codatend"];
                    atendimento.Servico.Codservico = (int)dr["codserv"];
                    atendimento.Pet.CodPet = (int)dr["codpet"];
                    atendimento.Funcionario.Cod = (int)dr["codfunc"];
                    atendimento.DataHora = (DateTime)dr["datahora"];
                    atendimento.Situacao = (string)dr["situacao"];

                    atends.Add(atendimento);
                }   
            }

            else
            {
                atends = null;



            }
            return atends;



        }

        public IList<Atendimento> BuscaFuncionario(int cod)
        {

            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select *from Atendimento Where codfunc=@codfunc";

            comando.Parameters.AddWithValue("@codfunc", cod);



            MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

            IList<Atendimento> atends = new List<Atendimento>();


            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    Atendimento atendimento = new Atendimento();

                    atendimento.AtendimentoCod = (int)dr["codatend"];
                    atendimento.Servico.Codservico = (int)dr["codserv"];
                    atendimento.Pet.CodPet = (int)dr["codpet"];
                    atendimento.Funcionario.Cod = (int)dr["codfunc"];
                    atendimento.DataHora = (DateTime)dr["datahora"];
                    atendimento.Situacao = (string)dr["situacao"];

                    atends.Add(atendimento);
                }
            }

            else
            {
                atends = null;



            }
            return atends;



        }





    }
}

