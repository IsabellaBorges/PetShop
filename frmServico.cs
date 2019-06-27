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
    public partial class frmServico : Form
    {
        public frmServico()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Servico serv = new Servico();
            ServicoBO servicoBO = new ServicoBO();

            serv.Codservico = Convert.ToInt16(txtCod.Text);
            serv.Tipo = cmbTipo.SelectedItem.ToString();
            serv.Porte = cmbPorte.SelectedItem.ToString();
            serv.Valor = Convert.ToDecimal(txtValor.Text);

            servicoBO.Gravar(serv);
            MessageBox.Show("Servico Cadastrado com Sucesso!");



        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Servico serv = new Servico();
            ServicoBO servicoBO = new ServicoBO();

            serv.Codservico = Convert.ToInt16(txtCod.Text);
            serv.Tipo = cmbTipo.SelectedItem.ToString().ToUpper();
            serv.Porte = cmbPorte.SelectedItem.ToString().ToUpper();
            serv.Valor = Convert.ToDecimal(txtValor.Text);

            servicoBO.Editar(serv);
            MessageBox.Show("Servico Editado com Sucesso!");

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            Servico serv = new Servico();
            ServicoBO servicoBO = new ServicoBO();

            try
            {
                serv.Codservico = Convert.ToInt16(txtCod.Text);

                
                dataGridView1.DataSource = servicoBO.BuscaCod(serv);



            }
            catch
            {
                MessageBox.Show("Preencha  corretamente as informações!!");
            }



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linhaSelecionada;
            linhaSelecionada = dataGridView1.CurrentRow;

            
            txtCod.Text= linhaSelecionada.Cells[0].Value.ToString();
            cmbTipo.SelectedItem= linhaSelecionada.Cells[1].Value;
            cmbPorte.SelectedItem= linhaSelecionada.Cells[2].Value;
            txtValor.Text= linhaSelecionada.Cells[3].Value.ToString();


        }
    }
}
