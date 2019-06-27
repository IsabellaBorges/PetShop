using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Correios.Net;
using PetShop_MVC_.MODEL;
using PetShop_MVC_.BO;


namespace PetShop_MVC_
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        

        private void mskCep_Leave_1(object sender, EventArgs e)
        {

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
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            ClienteBO clienteBO = new ClienteBO();

            //cliente.Cod = Convert.ToInt16(txtCodCliente.Text);
            cliente.Nome = txtNome.Text;
            cliente.Cpf = Convert.ToInt64(txtCPF.Text);
            cliente.Cep = mskCep.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Numero = txtNumero.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.email = txtEmail.Text;

            clienteBO.Gravar(cliente);
            MessageBox.Show("Cliente Cadastrado com Sucesso!");





        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            ClienteBO clienteBO = new ClienteBO();

            cliente.Cod = Convert.ToInt16(txtCodCliente.Text);
            cliente.Nome = txtNome.Text;
            cliente.Cpf = Convert.ToInt64(txtCPF.Text);
            cliente.Cep = mskCep.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Numero = txtNumero.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.email = txtEmail.Text;

            clienteBO.Editar(cliente);
            MessageBox.Show("Cliente editado com Sucesso!");
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            ClienteBO clienteBO = new ClienteBO();

            try
            {
                cliente.Cod = Convert.ToInt16(txtCodCliente.Text);

                clienteBO.BuscaPorCod(cliente);

                if (cliente.Nome == "")
                {
                    MessageBox.Show("Cliente não encontrado!");
                    
                }
                else
                {
                    
                    txtNome.Text = cliente.Nome;
                    txtCPF.Text = Convert.ToString(cliente.Cpf);
                    mskCep.Text = cliente.Cep;
                    txtEndereco.Text=cliente.Endereco;
                    txtNumero.Text= cliente.Numero;
                    txtCidade.Text=cliente.Cidade;
                    txtTelefone.Text=cliente.Telefone;
                    txtEmail.Text=cliente.email;

                }
            }
            catch
            {
                MessageBox.Show("Preencha  corretamente as informações!!");
            }
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {

            Cliente cliente = new Cliente();
            txtCodCliente.Clear();
            txtNome.Clear();
            mskCep.Clear();
            txtCPF.Clear();
            txtEndereco.Clear();
            txtCidade.Clear();
            txtNumero.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
        }
    }
}


    
    


