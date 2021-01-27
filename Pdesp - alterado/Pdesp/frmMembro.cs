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

namespace PDesp
{
    public partial class frmMembro : Form
    {
        private BindingSource bnMembro = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsMembro = new DataSet();

        public frmMembro()
        {
            InitializeComponent();
        }

        private void frmMembro_Load(object sender, EventArgs e)
        {
            try
            {

                Membro membro = new Membro();
                dsMembro.Tables.Add(membro.Listar());
                bnMembro.DataSource = dsMembro.Tables["Membro"];
                dgvMembro.DataSource = bnMembro;
                bnvMembro.BindingSource = bnMembro;

                txtId.DataBindings.Add("TEXT", bnMembro, "id_membro");
                txtNomeMembro.DataBindings.Add("TEXT", bnMembro, "nome_membro");
                txtPapelMembro.DataBindings.Add("TEXT", bnMembro, "papel_membro");
       
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNovoRegistro_Click(object sender, EventArgs e)
        {
            if (TabControl1.SelectedIndex == 0)
            {
                TabControl1.SelectTab(1);
            }

            bnMembro.AddNew();
            txtNomeMembro.Enabled = true;
            txtPapelMembro.Enabled = true;
            txtNomeMembro.Focus();
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovoRegistro.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;

            bInclusao = true; ;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // validar os dados
            if (txtNomeMembro.Text == "")
            {
                MessageBox.Show("Membro inválido!");
            }
            else
            {
                Membro RegMembro = new Membro();

                RegMembro.IdDespesa = Convert.ToInt16(txtId.Text);
                RegMembro.Nomemembro = txtNomeMembro.Text;
                RegMembro.Papelmembro = txtPapelMembro.Text;
                
                if (bInclusao)
                {
                    if (RegMembro.Salvar() > 0)
                    {
                        MessageBox.Show("Membro adicionado com sucesso!");

                        btnSalvar.Enabled = false;
                        txtId.Enabled = false;
                        txtNomeMembro.Enabled = false;
                        btnSalvar.Enabled = false; //Repete duas vezes?
                        btnAlterar.Enabled = true;
                        btnNovoRegistro.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;

                        bInclusao = false;

                        // recarrega o grid
                        dsMembro.Tables.Clear();
                        dsMembro.Tables.Add(RegMembro.Listar());
                        bnMembro.DataSource = dsMembro.Tables["Membro"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar membro!");
                    }
                }
                else
                {
                    if (RegMembro.Alterar() > 0)
                    {
                        MessageBox.Show("Membro alterado com sucesso!");

                        dsMembro.Tables.Clear();
                        dsMembro.Tables.Add(RegMembro.Listar());
                        txtId.Enabled = false;
                        txtNomeMembro.Enabled = false;
                        txtPapelMembro.Enabled = false;
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnNovoRegistro.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;

                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar membro!");
                    }

                }
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (TabControl1.SelectedIndex == 0)
            {
                TabControl1.SelectTab(1);
            }


            if (MessageBox.Show("Confirma exclusão?", "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Membro RegMembro = new Membro();

                RegMembro.IdDespesa = Convert.ToInt16(txtId.Text);
                RegMembro.Nomemembro = txtNomeMembro.Text;

                if (RegMembro.Excluir() > 0)
                {
                    MessageBox.Show("Membro excluído com sucesso!");
                    Membro R = new Membro();
                    dsMembro.Tables.Clear();
                    dsMembro.Tables.Add(R.Listar());
                    bnMembro.DataSource = dsMembro.Tables["Membro"];
                }
                else
                {
                    MessageBox.Show("Erro ao excluir Membro!");
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (TabControl1.SelectedIndex == 0)
            {
                TabControl1.SelectTab(1);
            }

            txtNomeMembro.Enabled = true;
            txtNomeMembro.Focus();
            btnSalvar.Enabled = true;
            txtPapelMembro.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovoRegistro.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            bInclusao = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bnMembro.CancelEdit();

            btnSalvar.Enabled = false;
            txtNomeMembro.Enabled = false;
            btnAlterar.Enabled = true;
            btnNovoRegistro.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
