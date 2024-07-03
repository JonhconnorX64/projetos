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
    public partial class Saudacoes : Form
    {
        public Saudacoes()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seja bem vinda(o) " + txtNome2.Text + " a empresa " + txtNome1.Text);
        }
    }
}
