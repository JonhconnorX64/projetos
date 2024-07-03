using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramasIdeias
{
    public partial class frmPessoa : Form
    {
        public frmPessoa()
        {
            InitializeComponent();
        }

        private void btnMostrarDataCompleta_Click(object sender, EventArgs e)
        {
            Validar objValidar = new Validar();
            string strMensagem = "O (A) ";
            strMensagem += txtNome.Text;
            strMensagem += "\r\n";
            strMensagem += objValidar.ClassificarQIPessoa(Convert.ToInt32(txtQI.Text));
            strMensagem += "\r\n";
            strMensagem += objValidar.CalcularIdadePessoa(Convert.ToInt32(txtDia.Text), Convert.ToInt32(txtMes.Text), Convert.ToInt32(txtAno.Text));
            lblInformacao.Text = strMensagem;
        }

        private void btnMostrarData_Click(object sender, EventArgs e)
        {
            Validar objValidar = new Validar();

            string strMensagem = "O (A)";

            strMensagem += txtNome.Text;
            strMensagem += "\r\n";
            strMensagem += objValidar.ClassificarQIeCalcularIdadePessoa(Convert.ToInt32(txtQI.Text), Convert.ToInt32(txtAno.Text), Convert.ToInt32(txtMes.Text));

            lblInformacao.Text = strMensagem;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtAno.Text = " ";
            txtDia.Text = " ";
            txtMes.Text = " ";
            txtQI.Text = " ";
            lblInformacao.Text = " ";
        }

    }
}
