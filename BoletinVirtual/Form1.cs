using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoletinVirtual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt1.Text = " ";
            txt2.Text = " ";
            txt3.Text = " ";
            txt4.Text = " ";
            txtResultado.Text = " ";
            txt1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int intNota1, intNota2, intNota3, intNota4, divisao = 4, calculo;

            try
            {
                intNota1 = Convert.ToInt16(txt1.Text);
                intNota2 = Convert.ToInt16(txt2.Text);
                intNota3 = Convert.ToInt16(txt3.Text);
                intNota4 = Convert.ToInt16(txt4.Text);

                calculo = ((intNota1 + intNota2 + intNota3 + intNota4) / divisao);

                if (calculo >= 5)
                {
                    txtResultado.Text = " Voçê foi aprovado! " + " Média: " + calculo;
                }
                else
                {
                    txtResultado.Text = " Voçê foi reprovado! " + "Média: " + calculo;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(" Voçê digitou uma letra", "Erro");
                    txt1.Focus();
            }
        }
    }
}
