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
    public class PetDAO
    {
        public void Insert(Pet pet)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Insert into Pet (codcli,nome, raca, porte, sexo, cor, especie) values (@codcli,@nome, @raca, @porte, @sexo, @cor, @especie)";

                comando.Parameters.AddWithValue("@codcli", pet.Cliente.Cod);
                comando.Parameters.AddWithValue("@nome", pet.Nome);
                comando.Parameters.AddWithValue("@raca", pet.Raca);
                comando.Parameters.AddWithValue("@porte", pet.Porte);
                comando.Parameters.AddWithValue("@sexo", pet.Sexo);
                comando.Parameters.AddWithValue("@cor", pet.Cor);
                comando.Parameters.AddWithValue("@especie", pet.Especie);



                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }
        }



        public void Update(Pet pet)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Update Pet set nome=@nome,codcli=@codcli, raca=@raca, porte=@porte, sexo=@sexo, cor=@cor, especie=@especie where codpet=@codpet";

                comando.Parameters.AddWithValue("@codpet", pet.CodPet);
                comando.Parameters.AddWithValue("@codcli", pet.Cliente.Cod);
                comando.Parameters.AddWithValue("@nome", pet.Nome);
                comando.Parameters.AddWithValue("@raca", pet.Raca);
                comando.Parameters.AddWithValue("@porte", pet.Porte);
                comando.Parameters.AddWithValue("@sexo", pet.Sexo);
                comando.Parameters.AddWithValue("@cor", pet.Cor);
                comando.Parameters.AddWithValue("@especie", pet.Especie);

                ConexaoBanco.CRUD(comando);
            }

            catch (Exception ex)
            {
                throw new Exception("Não foi possível Editar o Pet" + ex.Message);
            }
        }

        public IList<Pet> BuscaPorNome(string nome)
        {



            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Select *from Pet where nome like @nome";
                //comando.CommandText = "Select p.codpet, cli.codcli, p.nome FROM pet p, cliente cli where cli.codcli = p.codcli and p.nome like @nome";

                


                comando.Parameters.AddWithValue("@nome", "%" + nome + "%");


                ConexaoBanco.CRUD(comando);



                MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

                IList<Pet> pets = new List<Pet>();

               

                if (dr.HasRows)

                { 
                    while (dr.Read())
                    {
                       

                        Pet pet = new Pet();

                        pet.Cliente.Cod = (int)dr["codcli"];
                        pet.CodPet = (int)dr["codpet"];
                        pet.Nome = (string)dr["nome"];
                        pet.Raca = (string)dr["raca"];
                        pet.Porte = (string)dr["porte"];
                        pet.Sexo = (string)dr["sexo"];
                        pet.Cor = (string)dr["cor"];
                        pet.Especie = (string)dr["especie"];



                        pets.Add(pet);

                        
                    }
                }

                else
                {
                    pets = null;


                }
                return pets;





            }
        }
    } 
}
    