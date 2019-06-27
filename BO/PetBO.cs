using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop_MVC_.DAO;
using PetShop_MVC_.MODEL;

namespace PetShop_MVC_.BO
{
   public class PetBO
    {
        public void Gravar(Pet pet)
        {
            PetDAO petDAO = new PetDAO();


            if (pet.Nome != null)
            {
                if (pet.CodPet != 0)
                {
                    petDAO.Update(pet);
                }

                else
                {
                    petDAO.Insert(pet);
                }
            }


        }



        public IList<Pet> BuscarPorNome(Pet pet)
        {
            PetDAO petDao = new PetDAO();

            if (pet.Nome != "")
            {
                IList<Pet> petTemp = petDao.BuscaPorNome(pet.Nome);

                return petTemp;

            }
            else
            {
                return null;
            }


        }


    }



}
