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
    public partial class frmCalsalario : Form
    {
        public frmCalsalario()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string strNome;
            int intSalario, intAumento, intTotal;

            strNome = txtNome.Text;
            intSalario = Convert.ToInt16(txtSalario.Text);

            if (intSalario <= 800)
            {
                intAumento = intSalario * 30 / 100;
                intTotal = intAumento + intSalario;
                MessageBox.Show(strNome + " voçê terá um aumento de " + intAumento + " reais. Seu salário total será " + intTotal + " reais.");
            }
           
            else if (intSalario > 1500)
            {
                intAumento = intSalario * 5 / 100;
                intTotal = intAumento + intSalario;
                MessageBox.Show(strNome + " voçê terá um aumento de " + intAumento + " reais. Seu salário total será " + intTotal + " reais.");
            }
            else if (intSalario > 801 && intSalario < 1499)
            {
                intAumento = intSalario * 15 / 100;
                intTotal = intAumento + intSalario;
                MessageBox.Show(strNome + " voçê terá um aumento de " + intAumento + " reais. Seu salário total será " + intTotal + " reais.");
            }
            txtNome.Text = " ";
            txtSalario.Text = " ";
            txtNome.Focus();

        }
    }
}
