using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PetShop_MVC_.MODEL;
using PetShop_MVC_.BO;



namespace PetShop_MVC_
{
    public partial class frmAtendimento : Form
    {
        public frmAtendimento()
        {
            InitializeComponent();
        }

        private void frmAtendimento_Load(object sender, EventArgs e)
        {




            grbBuscas.Visible = false;
            dtpDataHora.Format = DateTimePickerFormat.Custom;
            dtpDataHora.CustomFormat = "dd-MM-yyyy / HH:mm:ss";
            dtpDataHora.Value = DateTime.Now;




        }

        private void button1_Click(object sender, EventArgs e)
        {
            grbBuscas.Visible = true;
        }

        private void btnBuscaPet_Click(object sender, EventArgs e)
        {


            Atendimento atendimento = new Atendimento();
            AtendimentoBO atendimentoBO = new AtendimentoBO();


            try
            {


                atendimento.Pet.CodPet = Convert.ToInt16(txtCodPet.Text);

                dgvDados.DataSource = atendimentoBO.BuscaPet(atendimento);

                atendimentoBO.BuscaPet(atendimento);





                //txtCodAtend.Text = Convert.ToString(atendimento.AtendimentoCod);
                //txtCodServ.Text = Convert.ToString(atendimento.Servico.Codservico);
                //txtCodPet.Text = Convert.ToString (atendimento.Pet.CodPet);
                //txtCodFun.Text = Convert.ToString (atendimento.Funcionario.Cod);
                //cmbSituacao.SelectedItem = Convert.ToString (atendimento.Situacao);
                //dtpDataHora.Value = atendimento.DataHora;


            }
            catch
            {
                MessageBox.Show("Preencha  corretamente as informações!!");
            }
        }

        private void grbBuscas_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscaFunc_Click(object sender, EventArgs e)
        {


            Atendimento atendimento = new Atendimento();
            AtendimentoBO atendimentoBO = new AtendimentoBO();


            try
            {


                atendimento.Funcionario.Cod = Convert.ToInt16(txtCodFun.Text);

                dgvDados.DataSource = atendimentoBO.BuscaFuncionario(atendimento);

                atendimentoBO.BuscaFuncionario(atendimento);






            }
            catch
            {
                MessageBox.Show("Preencha  corretamente as informações!!");
            }
        }


        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Atendimento atendimento = new Atendimento();
            AtendimentoBO atendimentoBO = new AtendimentoBO();

            atendimento.Servico.Codservico = Convert.ToInt16(txtCodServ.Text);
            atendimento.Pet.CodPet = Convert.ToInt16(txtCodPet.Text);
            atendimento.Funcionario.Cod = Convert.ToInt16(txtCodFun.Text);
            atendimento.Situacao = Convert.ToString(cmbSituacao.SelectedItem);
            atendimento.DataHora = dtpDataHora.Value;



            atendimentoBO.Gravar(atendimento);
            MessageBox.Show("Atendimento Cadastrado com Sucesso!");




        }

        private void btnBuscaPeriodo_Click(object sender, EventArgs e)
        {


            Atendimento atendimento = new Atendimento();
            AtendimentoBO atendimentoBO = new AtendimentoBO();


            try
            {

                DateTime DtInicio;
                DateTime DtFim;

                DtInicio = dtpInicio.Value;
                DtFim = dtpFim.Value;

                dgvDados.DataSource = atendimentoBO.BuscaPeriodo(DtInicio, DtFim);

                atendimentoBO.BuscaPeriodo(DtInicio, DtFim);

                


            }
            catch
            {
                MessageBox.Show("Preencha  corretamente as informações!!");
            }



        }
}  }


