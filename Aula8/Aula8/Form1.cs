using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            int cont = 0;

            foreach (char c in richTextBox1.Text)
            {
                if (char.IsWhiteSpace(c))
                {
                    cont += 1;
                }
            }
            MessageBox.Show("Numero de espaços em branco: " + cont.ToString());
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            int cont = 0;

            foreach (char c in richTextBox1.Text)
            {
                if (c == 'R' || c == 'r')
                {
                    cont += 1;
                }
            }
            MessageBox.Show("Texto têm " + cont.ToString() + " R");
        }

        private void btnPares_Click(object sender, EventArgs e)
        {
            int cont = 0;

            for (int i = 1; i < richTextBox1.Text.Length; i++)
            {
                if (richTextBox1.Text[i] == richTextBox1.Text[i - 1])
                {
                    cont++;
                }
            }
            MessageBox.Show("letras iguais sequenciais: " + cont.ToString());
        }

        private void btnH_Click(object sender, EventArgs e)
        {

            double h = 1;
            double n;

            if (double.TryParse(txtN.Text, out n))
            {
                for (int i = 0; i <= n; i++)
                {
                    h += 1 / i;
                }

                MessageBox.Show(h.ToString());
            }
            else
            {
                MessageBox.Show("Erro!");
            }
        }
    }
}