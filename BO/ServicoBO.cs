using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop_MVC_.DAO;
using PetShop_MVC_.MODEL;

namespace PetShop_MVC_.BO
{
    public class ServicoBO
    {

        public void Gravar(Servico servico)
        {
            ServicoDAO servicoDAO = new ServicoDAO();

            if ((servico.Valor != 0) && (servico.Tipo != ""))
            {

                servicoDAO.Insert(servico);

            }

        }

        public void Editar(Servico servico)
        {
            ServicoDAO servicoDAO = new ServicoDAO();
            if (servico.Codservico!=0)
            {
                servicoDAO.Update(servico);

            }
        }

        public IList<Servico> BuscaCod(Servico servico)
        {
            ServicoDAO servicoDao = new ServicoDAO();



            if (servico.Codservico != 0)
            {
                IList<Servico> servTemp = servicoDao.BuscaCod(servico.Codservico);
                return servTemp;




            }
            else
            {

                return null;


            }
        }



    }
}
