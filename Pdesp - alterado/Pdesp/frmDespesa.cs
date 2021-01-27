using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    public partial class frmDespesa : Form
    {
        private BindingSource bnDespesa = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsDespesa = new DataSet();
        public frmDespesa()
        {
            InitializeComponent();
        }

        private void frmDespesa_Load(object sender, EventArgs e)
        {
            try
            {

                Despesa despesa = new Despesa();
                dsDespesa.Tables.Add(despesa.Listar());
                bnDespesa.DataSource = dsDespesa.Tables["Despesa"];
                dgvDespesa.DataSource = bnDespesa;
                bnvDespesa.BindingSource = bnDespesa;

                txtId.DataBindings.Add("TEXT", bnDespesa, "id_Despesa");
                txtDataDespesa.DataBindings.Add("TEXT", bnDespesa, "data_despesa");
                txtValorDespesa.DataBindings.Add("TEXT", bnDespesa, "valor_despesa");
                txtObsDespesa.DataBindings.Add("TEXT", bnDespesa, "obs_despesa");

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

            bnDespesa.AddNew();
            txtDataDespesa.Enabled = true;
            txtValorDespesa.Enabled = true;
            txtObsDespesa.Focus();
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
            if (txtDataDespesa.Text == "")
            {
                MessageBox.Show("Data inválida!");
            }
            else
            {
                Despesa RegDespesa = new Despesa();

                RegDespesa.Iddespesa = Convert.ToInt16(txtId.Text);
                RegDespesa.Datadespesa = Convert.ToDateTime(txtDataDespesa.Text);
                RegDespesa.Valordespesa = Convert.ToSingle(txtValorDespesa.Text);
                RegDespesa.Obsdespesa = txtObsDespesa.Text;

                if (bInclusao)
                {
                    if (RegDespesa.Salvar() > 0)
                    {
                        MessageBox.Show("Despesa adicionada com sucesso!");

                        btnSalvar.Enabled = false;
                        txtId.Enabled = false;
                        txtDataDespesa.Enabled = false;
                        txtValorDespesa.Enabled = false;
                        txtObsDespesa.Enabled = false;
                        btnSalvar.Enabled = false; //Repete duas vezes?
                        btnAlterar.Enabled = true;
                        btnNovoRegistro.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;

                        bInclusao = false;

                        // recarrega o grid
                        dsDespesa.Tables.Clear();
                        dsDespesa.Tables.Add(RegDespesa.Listar());
                        bnDespesa.DataSource = dsDespesa.Tables["Despesa"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar despesa!");
                    }
                }
                else
                {
                    if (RegDespesa.Alterar() > 0)
                    {
                        MessageBox.Show("Despesa alterada com sucesso!");

                        dsDespesa.Tables.Clear();
                        dsDespesa.Tables.Add(RegDespesa.Listar());
                        txtId.Enabled = false;
                        txtDataDespesa.Enabled = false;
                        txtValorDespesa.Enabled = false;
                        txtObsDespesa.Enabled = false;
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnNovoRegistro.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;

                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar despesa!");
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
                Despesa RegDespesa = new Despesa();

                RegDespesa.Iddespesa = Convert.ToInt16(txtId.Text);
                RegDespesa.Datadespesa = Convert.ToDateTime(txtDataDespesa.Text);
                RegDespesa.Valordespesa = Convert.ToSingle(txtValorDespesa.Text);
                RegDespesa.Obsdespesa = txtObsDespesa.Text;

                if (RegDespesa.Excluir() > 0)
                {
                    MessageBox.Show("Despesa excluída com sucesso!");
                    Despesa R = new Despesa();
                    dsDespesa.Tables.Clear();
                    dsDespesa.Tables.Add(R.Listar());
                    bnDespesa.DataSource = dsDespesa.Tables["Despesa"];
                }
                else
                {
                    MessageBox.Show("Erro ao excluir Despesa!");
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (TabControl1.SelectedIndex == 0)
            {
                TabControl1.SelectTab(1);
            }

            txtDataDespesa.Enabled = true;
            txtDataDespesa.Focus();
            btnSalvar.Enabled = true;
            txtValorDespesa.Enabled = true;
            txtObsDespesa.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovoRegistro.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            bInclusao = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bnDespesa.CancelEdit();

            btnSalvar.Enabled = false;
            txtDataDespesa.Enabled = false;
            txtValorDespesa.Enabled = false;
            txtObsDespesa.Enabled = false;
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

