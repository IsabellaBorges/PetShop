using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetShop_MVC_.MODEL;
using PetShop_MVC_.BO;

namespace PetShop_MVC_
{
    public partial class frmPet : Form
    {
        public frmPet()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
           
            Pet pet = new Pet();
            PetBO petBO = new PetBO();
            //pet.CodPet = Convert.ToInt16(txtCodPet.Text);
            pet.Cliente.Cod= Convert.ToInt16(txtCodCliente.Text);
            pet.Nome = txtNome.Text;
            pet.Raca = txtRaca.Text;
            pet.Porte = cmbPorte.SelectedItem.ToString();
            pet.Sexo = cmbSexo.SelectedItem.ToString();
            pet.Cor = txtCor.Text;
            pet.Especie = txtEspecie.Text;

            petBO.Gravar(pet);
            MessageBox.Show("Dog Cadastrado com Sucesso!");




        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            Pet pet = new Pet();
            PetBO petBO = new PetBO();
            pet.CodPet = Convert.ToInt16(txtCodPet.Text);
            pet.Cliente.Cod = Convert.ToInt16(txtCodCliente.Text);
            pet.Nome = txtNome.Text;
            pet.Raca = txtRaca.Text;
            pet.Porte = cmbPorte.SelectedItem.ToString();
            pet.Sexo = cmbSexo.SelectedItem.ToString();
            pet.Cor = txtCor.Text;
            pet.Especie = txtEspecie.Text;

            petBO.Gravar(pet);
            MessageBox.Show("Dog Editado com Sucesso!");


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Pet pet = new Pet();
            PetBO petBO = new PetBO();

            try
            {

                pet.Nome = txtNome.Text;
                
                dataGridView1.DataSource = petBO.BuscarPorNome(pet);
                




            }
            catch
            {
                MessageBox.Show("Preencha os dados corretamente");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linhaSelecionada;
            linhaSelecionada = dataGridView1.CurrentRow;

            txtCodPet.Text = linhaSelecionada.Cells[0].Value.ToString();
            txtNome.Text = linhaSelecionada.Cells[1].Value.ToString();
            txtEspecie.Text = linhaSelecionada.Cells[2].Value.ToString();
            txtRaca.Text= linhaSelecionada.Cells[3].Value.ToString();
            cmbPorte.SelectedItem= linhaSelecionada.Cells[4].Value;
            cmbSexo.SelectedItem= linhaSelecionada.Cells[5].Value; 
            txtCor.Text= linhaSelecionada.Cells[6].Value.ToString();
            txtCodCliente.Text = linhaSelecionada.Cells[7].Value.ToString(); 



        }
    }
 }

