using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop_MVC_
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

       

        

        private void button1_Click(object sender, EventArgs e)
        {
            frmAtendimento atend = new frmAtendimento();
            atend.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnPet_Click(object sender, EventArgs e)
        {
            frmPet pet = new frmPet();
            pet.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmCliente cliente = new frmCliente();
            cliente.Show();

        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            frmFuncionario funcionario = new frmFuncionario();
            funcionario.Show();
        }

        private void btnServico_Click(object sender, EventArgs e)
        {
            frmServico servico = new frmServico();
            servico.Show();
        }
    }
}
