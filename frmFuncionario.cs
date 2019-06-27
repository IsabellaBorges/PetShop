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
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

        private void mskCep_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(mskCep.Text))
            {
                using (var ws = new ReferenceBuscaCep.AtendeClienteClient())
                {
                    try
                    {
                        var endereco = ws.consultaCEP(mskCep.Text.Trim());

                        txtBairro.Text = endereco.bairro;
                        txtEstado.Text = endereco.uf;
                        txtCidade.Text = endereco.cidade;
                        txtEndereco.Text = endereco.end;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Informe um CEP Válido!!!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Funcionario fun = new Funcionario();
            FuncionarioBO funcionarioBO = new FuncionarioBO();

            //fun.Cod = Convert.ToInt16(txtCod.Text);
            fun.Nome = txtNome.Text;
            fun.Cpf = Convert.ToInt64(txtCPF.Text);
            fun.Cep = mskCep.Text;
            fun.Endereco = txtEndereco.Text;
            fun.Numero = txtNumero.Text;
            fun.Cidade = txtCidade.Text;
            fun.Telefone = txtTelefone.Text;
            fun.CartTrab = txtCartTrab.Text;
            fun.Salario = Convert.ToDecimal(txtSalario.Text);

            funcionarioBO.Gravar(fun);
            MessageBox.Show("Funcionario Cadastrado com Sucesso!");





        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Funcionario fun = new Funcionario();
            FuncionarioBO funcionarioBO = new FuncionarioBO();

            fun.Cod = Convert.ToInt16(txtCod.Text);
            fun.Nome = txtNome.Text;
            fun.Cpf = Convert.ToInt64(txtCPF.Text);
            fun.Cep = mskCep.Text;
            fun.Endereco = txtEndereco.Text;
            fun.Numero = txtNumero.Text;
            fun.Cidade = txtCidade.Text;
            fun.Telefone = txtTelefone.Text;
            fun.CartTrab = txtCartTrab.Text;
            fun.Salario = Convert.ToDecimal(txtSalario.Text);

            funcionarioBO.Editar(fun);
            MessageBox.Show("Funcionario Editado com Sucesso!");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            Funcionario fun = new Funcionario();
            FuncionarioBO funcionarioBO = new FuncionarioBO();

            try
            {
               fun.Cod = Convert.ToInt16(txtCod.Text);

                funcionarioBO.BuscaPorCod(fun);
                if (fun.Nome == "")
                {
                    MessageBox.Show("Funcionario não encontrado!");

                }
                else
                {
                    txtCod.Text  =  Convert.ToString(fun.Cod);
                    txtNome.Text = fun.Nome;
                    txtCPF.Text = Convert.ToString(fun.Cpf);
                    mskCep.Text = fun.Cep;
                    txtEndereco.Text = fun.Endereco;
                    txtNumero.Text = fun.Numero;
                    txtCidade.Text = fun.Cidade;
                    txtTelefone.Text = fun.Telefone;
                    txtCartTrab.Text = fun.CartTrab;
                    txtSalario.Text = Convert.ToString(fun.Salario);

                }
            }
            catch
            {
                MessageBox.Show("Preencha  corretamente as informações!!");
            }


        }

        private void btnCalcularSal_Click(object sender, EventArgs e)
        {

            Funcionario fun = new Funcionario();
            FuncionarioBO funcionarioBO = new FuncionarioBO();
            try
            {
                fun.Cod = Convert.ToInt16(txtCod.Text);

                funcionarioBO.calculaSalario(fun);

                

                fun.Salariofinal=fun.Salariofinal+Convert.ToDecimal(txtSalario.Text);
                txtSal.Visible = true;
                txtSal.Text = Convert.ToString(fun.Salariofinal);


            }
            catch
            {
                MessageBox.Show("Preencha  corretamente as informações!!");
            }



        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {

            Funcionario fun = new Funcionario();

            txtCod.Clear();
            txtNome.Clear();
            txtCPF.Clear();
            mskCep.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtCidade.Clear();
            txtTelefone.Clear();
            txtCartTrab.Clear();
            txtSalario.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
        }
    }

}

