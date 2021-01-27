using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

/*
 
 FALTA FAZER:
 * 
 form Despesas - linkar as chaves estrangeiras no form despesa (ver página 18 do teoria_LP_aula_12)
 inserir essas duas chaves estrangeiras no form Despesas (visual)
 * 
 * 
 */

namespace PDesp
{
    public partial class frmPrincipal : Form
    {
        public static SqlConnection conexao;
        
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPDesp_Load(object sender, EventArgs e)
        {
            try 
            {
                conexao = new SqlConnection("Data Source=Apolo;Initial Catalog=LP2;Persist Security Info=True;User ID=BD1911032;PASSWORD=BD1911032");
                //conexao = new SqlConnection("Data Source=PROFDENILCE "+")
                conexao.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro de Banco de Dados =/" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Outros Erros =/" + ex.Message);
            }

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rafael de Oliveira Brisola RA: 0030481911032 e Renan Casagrande Andrade RA: 0030481911033");
        }

        private void membroFamiliarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMembro frm = new frmMembro();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void tipoDeDespesaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoDespesa frm = new frmTipoDespesa();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void despesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDespesa frm = new frmDespesa();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}
