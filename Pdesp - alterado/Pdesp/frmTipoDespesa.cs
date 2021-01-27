using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDesp
{
    public partial class frmTipoDespesa : Form
    {
        private BindingSource bnTipoDespesa = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsTipoDespesa = new DataSet();

        public frmTipoDespesa()
        {
            InitializeComponent();
        }

        private void frmTipoDespesa_Load(object sender, EventArgs e)
        {
            try
            {

                TipoDespesa tipoDespesa = new TipoDespesa();
                dsTipoDespesa.Tables.Add(tipoDespesa.Listar());
                bnTipoDespesa.DataSource = dsTipoDespesa.Tables["TipoDespesa"];
                dgvTipoDespesa.DataSource = bnTipoDespesa;
                bnvTipoDespesa.BindingSource = bnTipoDespesa;

                txtId.DataBindings.Add("TEXT", bnTipoDespesa, "id_tipoDespesa");
                txtTipoDespesa.DataBindings.Add("TEXT", bnTipoDespesa, "nome_tipodespesa");
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

            bnTipoDespesa.AddNew();
            txtTipoDespesa.Enabled = true;
            txtTipoDespesa.Focus();
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
            if (txtTipoDespesa.Text == "")
            {
                MessageBox.Show("Tipo de despesa inválido!");
            }
            else
            {
                TipoDespesa RegTipoDespesa = new TipoDespesa();

                RegTipoDespesa.Idtipodespesa = Convert.ToInt16(txtId.Text);
                RegTipoDespesa.Nometipodespesa = txtTipoDespesa.Text;

                if (bInclusao)
                {
                    if (RegTipoDespesa.Salvar() > 0)
                    {
                        MessageBox.Show("Tipo de despesa adicionado com sucesso!");

                        btnSalvar.Enabled = false;
                        txtId.Enabled = false;
                        txtTipoDespesa.Enabled = false;
                        btnSalvar.Enabled = false; //Repete duas vezes?
                        btnAlterar.Enabled = true;
                        btnNovoRegistro.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;

                        bInclusao = false;

                        // recarrega o grid
                        dsTipoDespesa.Tables.Clear();
                        dsTipoDespesa.Tables.Add(RegTipoDespesa.Listar());
                        bnTipoDespesa.DataSource = dsTipoDespesa.Tables["TipoDespesa"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar tipo despesa!");
                    }
                }
                else
                {
                    if (RegTipoDespesa.Alterar() > 0)
                    {
                        MessageBox.Show("Tipo de despesa alterado com sucesso!");

                        dsTipoDespesa.Tables.Clear();
                        dsTipoDespesa.Tables.Add(RegTipoDespesa.Listar());
                        txtId.Enabled = false;
                        txtTipoDespesa.Enabled = false;
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnNovoRegistro.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar Tipo de despesa!");
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
                TipoDespesa RegTipoDespesa = new TipoDespesa();

                RegTipoDespesa.Idtipodespesa = Convert.ToInt16(txtId.Text);
                RegTipoDespesa.Nometipodespesa = txtTipoDespesa.Text;

                if (RegTipoDespesa.Excluir() > 0)
                {
                    MessageBox.Show("Tipo despesa excluído com sucesso!");
                    TipoDespesa R = new TipoDespesa();
                    dsTipoDespesa.Tables.Clear();
                    dsTipoDespesa.Tables.Add(R.Listar());
                    bnTipoDespesa.DataSource = dsTipoDespesa.Tables["TipoDespesa"];
                }
                else
                {
                    MessageBox.Show("Erro ao excluir Tipo de despesa!");
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (TabControl1.SelectedIndex == 0)
            {
                TabControl1.SelectTab(1);
            }

            txtTipoDespesa.Enabled = true;
            txtTipoDespesa.Focus();
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovoRegistro.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            bInclusao = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bnTipoDespesa.CancelEdit();

            btnSalvar.Enabled = false;
            txtTipoDespesa.Enabled = false;
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
