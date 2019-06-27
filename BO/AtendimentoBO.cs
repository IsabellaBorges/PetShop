using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop_MVC_.DAO;
using PetShop_MVC_.MODEL;


namespace PetShop_MVC_.BO
{
    public class AtendimentoBO
    {
        public void Gravar(Atendimento atendimento)
        {
            AtendimentoDAO atendimentoDAO = new AtendimentoDAO();

            if (atendimento.Situacao != "")
            {

                atendimentoDAO.Insert(atendimento);

            }
        }



        public IList<Atendimento> BuscaPet(Atendimento atendimento)
        {
            AtendimentoDAO atendDao = new AtendimentoDAO();



            if (atendimento.Pet.CodPet > 0)

            {
                IList<Atendimento> petTemp = atendDao.BuscaPet(atendimento.Pet.CodPet);

                return petTemp;

                //atendimento.AtendimentoCod = petTemp.AtendimentoCod;
                //atendimento.Servico.Codservico =petTemp.Servico.Codservico;
                //atendimento.Pet.CodPet = petTemp.Pet.CodPet;
                //atendimento.Funcionario.Cod = petTemp.Funcionario.Cod;
                //atendimento.Situacao = petTemp.Situacao;
                //atendimento.DataHora = petTemp.DataHora;


            }
            else
            {
                return null;
            }

        }
        public IList<Atendimento> BuscaFuncionario(Atendimento atendimento)
        {
            AtendimentoDAO atendDao = new AtendimentoDAO();



            if (atendimento.Funcionario.Cod > 0)

            {
                IList<Atendimento> funcTemp = atendDao.BuscaFuncionario(atendimento.Funcionario.Cod);

                return funcTemp;




            }
            else
            {
                return null;
            }




        }



        public IList<Atendimento> BuscaPeriodo(DateTime DtInicio, DateTime DtFim)
        {
            AtendimentoDAO atendDao = new AtendimentoDAO();



            if ((DtFim != null) && (DtInicio != null))

            {
                IList<Atendimento> DataTemp = atendDao.BuscaPeriodo(DtInicio, DtFim);

                return DataTemp;




            }
            else
            {
                return null;
            }
        }
    } 
    }
    


