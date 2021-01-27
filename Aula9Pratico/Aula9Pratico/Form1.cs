using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;


namespace Aula9Pratico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string aux="";
            double[] vetor = new double[20];
                        
            for (int i = 0; i < 20; i++)
            {
                 aux = Interaction.InputBox("entre com um numero", "entre com um numero");
                if (!(double.TryParse(aux ,out vetor[i])))
                {
                         MessageBox.Show("invalido");
                         i--;
                }
                
            }
            Array.Reverse(vetor);

            aux = "";
            for (int i = 0; i < 20; i++)
            {
                aux += vetor[i].ToString() + "\n";
            }
            MessageBox.Show(aux);
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string aux = "";
            double[] vetor = new double[20];

            for (int i = 0; i < 20; i++)
            {
                aux = Interaction.InputBox("entre com um numero", "entre com um numero");
                if (!(double.TryParse(aux, out vetor[i])))
                {
                    MessageBox.Show("invalido");
                    i--;
                }

            }
            Array.Reverse(vetor);

            aux = "";
            for (int i = 0; i < 20; i++)
            {
                aux += vetor[i].ToString() + "\n";
            }
            MessageBox.Show(aux);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int [] Quantidade = new int[10];
            double [] Preço = new double[10];
            string aux = ""; 

            for (int i = 0; i < 10; i++)
            {
               Interaction.InputBox("Entre com o Valor","Entre com o valor");
               double.TryParse(aux,out ); 
            }
        }
    }
}
