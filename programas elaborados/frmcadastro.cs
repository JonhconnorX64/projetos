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
    public partial class frmcadastro : Form
    {
        public frmcadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Nome, Civil;
            int Idade;

            Idade = Convert.ToInt16(lblIdade.Text);
            Nome = lblNome.Text;
            Civil = lblCivil.Text;

            txtCadastro.Text = (Nome + " de " + Idade + " anos " + Civil + "." + "\r\n \r\nCadastro feito com sucesso! ");

        }

    }
}
