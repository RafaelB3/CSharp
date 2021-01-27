namespace PDesp
{
    partial class frmDespesa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDespesa));
            this.bnvDespesa = new System.Windows.Forms.BindingNavigator(this.components);
            this.BindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.BindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.BindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.BindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNovoRegistro = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnAlterar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.Dados = new System.Windows.Forms.TabPage();
            this.dgvDespesa = new System.Windows.Forms.DataGridView();
            this.Detalhes = new System.Windows.Forms.TabPage();
            this.txtObsDespesa = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorDespesa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDataDespesa = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bnvDespesa)).BeginInit();
            this.bnvDespesa.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.Dados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesa)).BeginInit();
            this.Detalhes.SuspendLayout();
            this.SuspendLayout();
            // 
            // bnvDespesa
            // 
            this.bnvDespesa.AddNewItem = null;
            this.bnvDespesa.CountItem = this.BindingNavigatorCountItem;
            this.bnvDespesa.DeleteItem = null;
            this.bnvDespesa.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bnvDespesa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BindingNavigatorMoveFirstItem,
            this.BindingNavigatorMovePreviousItem,
            this.BindingNavigatorSeparator,
            this.BindingNavigatorPositionItem,
            this.BindingNavigatorCountItem,
            this.BindingNavigatorSeparator1,
            this.BindingNavigatorMoveNextItem,
            this.BindingNavigatorMoveLastItem,
            this.BindingNavigatorSeparator2,
            this.btnNovoRegistro,
            this.btnExcluir,
            this.btnSalvar,
            this.btnAlterar,
            this.btnCancelar,
            this.btnSair});
            this.bnvDespesa.Location = new System.Drawing.Point(0, 0);
            this.bnvDespesa.MoveFirstItem = this.BindingNavigatorMoveFirstItem;
            this.bnvDespesa.MoveLastItem = this.BindingNavigatorMoveLastItem;
            this.bnvDespesa.MoveNextItem = this.BindingNavigatorMoveNextItem;
            this.bnvDespesa.MovePreviousItem = this.BindingNavigatorMovePreviousItem;
            this.bnvDespesa.Name = "bnvDespesa";
            this.bnvDespesa.PositionItem = this.BindingNavigatorPositionItem;
            this.bnvDespesa.Size = new System.Drawing.Size(460, 31);
            this.bnvDespesa.TabIndex = 7;
            this.bnvDespesa.Text = "bnvCidade";
            // 
            // BindingNavigatorCountItem
            // 
            this.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem";
            this.BindingNavigatorCountItem.Size = new System.Drawing.Size(37, 28);
            this.BindingNavigatorCountItem.Text = "de {0}";
            this.BindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // BindingNavigatorMoveFirstItem
            // 
            this.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveFirstItem.Image")));
            this.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem";
            this.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.BindingNavigatorMoveFirstItem.Text = "Primeiro registro";
            // 
            // BindingNavigatorMovePreviousItem
            // 
            this.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMovePreviousItem.Image")));
            this.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem";
            this.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.BindingNavigatorMovePreviousItem.Text = "Registro anterior";
            // 
            // BindingNavigatorSeparator
            // 
            this.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator";
            this.BindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // BindingNavigatorPositionItem
            // 
            this.BindingNavigatorPositionItem.AccessibleName = "Position";
            this.BindingNavigatorPositionItem.AutoSize = false;
            this.BindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem";
            this.BindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.BindingNavigatorPositionItem.Text = "0";
            this.BindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // BindingNavigatorSeparator1
            // 
            this.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1";
            this.BindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // BindingNavigatorMoveNextItem
            // 
            this.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveNextItem.Image")));
            this.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem";
            this.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.BindingNavigatorMoveNextItem.Text = "Próximo registro";
            // 
            // BindingNavigatorMoveLastItem
            // 
            this.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveLastItem.Image")));
            this.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem";
            this.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.BindingNavigatorMoveLastItem.Text = "Último Registro";
            // 
            // BindingNavigatorSeparator2
            // 
            this.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2";
            this.BindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // btnNovoRegistro
            // 
            this.btnNovoRegistro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNovoRegistro.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoRegistro.Image")));
            this.btnNovoRegistro.Name = "btnNovoRegistro";
            this.btnNovoRegistro.RightToLeftAutoMirrorImage = true;
            this.btnNovoRegistro.Size = new System.Drawing.Size(28, 28);
            this.btnNovoRegistro.Text = "Adicionar Novo Registro";
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.RightToLeftAutoMirrorImage = true;
            this.btnExcluir.Size = new System.Drawing.Size(28, 28);
            this.btnExcluir.Text = "Excluir";
            // 
            // btnSalvar
            // 
            this.btnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(28, 28);
            this.btnSalvar.Text = "Salvar Registros";
            // 
            // btnAlterar
            // 
            this.btnAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(28, 28);
            this.btnAlterar.Text = "Alterar Registro";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(28, 28);
            this.btnCancelar.Text = "Cancelar Alteração";
            // 
            // btnSair
            // 
            this.btnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(28, 28);
            this.btnSair.Text = "Sair";
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.Dados);
            this.TabControl1.Controls.Add(this.Detalhes);
            this.TabControl1.Location = new System.Drawing.Point(0, 91);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(356, 226);
            this.TabControl1.TabIndex = 6;
            // 
            // Dados
            // 
            this.Dados.Controls.Add(this.dgvDespesa);
            this.Dados.Location = new System.Drawing.Point(4, 22);
            this.Dados.Name = "Dados";
            this.Dados.Padding = new System.Windows.Forms.Padding(3);
            this.Dados.Size = new System.Drawing.Size(348, 200);
            this.Dados.TabIndex = 0;
            this.Dados.Text = "Dados";
            this.Dados.UseVisualStyleBackColor = true;
            // 
            // dgvDespesa
            // 
            this.dgvDespesa.AllowUserToAddRows = false;
            this.dgvDespesa.AllowUserToDeleteRows = false;
            this.dgvDespesa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDespesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDespesa.Location = new System.Drawing.Point(0, 3);
            this.dgvDespesa.MaximumSize = new System.Drawing.Size(346, 182);
            this.dgvDespesa.MinimumSize = new System.Drawing.Size(346, 182);
            this.dgvDespesa.Name = "dgvDespesa";
            this.dgvDespesa.ReadOnly = true;
            this.dgvDespesa.Size = new System.Drawing.Size(346, 182);
            this.dgvDespesa.TabIndex = 0;
            // 
            // Detalhes
            // 
            this.Detalhes.Controls.Add(this.txtObsDespesa);
            this.Detalhes.Controls.Add(this.label2);
            this.Detalhes.Controls.Add(this.txtValorDespesa);
            this.Detalhes.Controls.Add(this.label1);
            this.Detalhes.Controls.Add(this.txtDataDespesa);
            this.Detalhes.Controls.Add(this.txtId);
            this.Detalhes.Controls.Add(this.lblCidade);
            this.Detalhes.Controls.Add(this.lblId);
            this.Detalhes.Location = new System.Drawing.Point(4, 22);
            this.Detalhes.Name = "Detalhes";
            this.Detalhes.Padding = new System.Windows.Forms.Padding(3);
            this.Detalhes.Size = new System.Drawing.Size(348, 200);
            this.Detalhes.TabIndex = 1;
            this.Detalhes.Text = "Detalhes";
            this.Detalhes.UseVisualStyleBackColor = true;
            // 
            // txtObsDespesa
            // 
            this.txtObsDespesa.Location = new System.Drawing.Point(141, 157);
            this.txtObsDespesa.MaxLength = 50;
            this.txtObsDespesa.Name = "txtObsDespesa";
            this.txtObsDespesa.Size = new System.Drawing.Size(125, 34);
            this.txtObsDespesa.TabIndex = 6;
            this.txtObsDespesa.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Observação Despesa";
            // 
            // txtValorDespesa
            // 
            this.txtValorDespesa.Enabled = false;
            this.txtValorDespesa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtValorDespesa.Location = new System.Drawing.Point(141, 118);
            this.txtValorDespesa.MaxLength = 10;
            this.txtValorDespesa.Name = "txtValorDespesa";
            this.txtValorDespesa.Size = new System.Drawing.Size(121, 20);
            this.txtValorDespesa.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valor da Despesa";
            // 
            // txtDataDespesa
            // 
            this.txtDataDespesa.Enabled = false;
            this.txtDataDespesa.Location = new System.Drawing.Point(141, 74);
            this.txtDataDespesa.Name = "txtDataDespesa";
            this.txtDataDespesa.Size = new System.Drawing.Size(121, 20);
            this.txtDataDespesa.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(141, 40);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(121, 20);
            this.txtId.TabIndex = 1;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(25, 77);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(90, 13);
            this.lblCidade.TabIndex = 1;
            this.lblCidade.Text = "Data de Despesa";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(25, 43);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            // 
            // frmDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 337);
            this.Controls.Add(this.bnvDespesa);
            this.Controls.Add(this.TabControl1);
            this.Name = "frmDespesa";
            this.ShowIcon = false;
            this.Text = "Despesa";
            this.Load += new System.EventHandler(this.frmDespesa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnvDespesa)).EndInit();
            this.bnvDespesa.ResumeLayout(false);
            this.bnvDespesa.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.Dados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesa)).EndInit();
            this.Detalhes.ResumeLayout(false);
            this.Detalhes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.BindingNavigator bnvDespesa;
        internal System.Windows.Forms.ToolStripLabel BindingNavigatorCountItem;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMoveFirstItem;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMovePreviousItem;
        internal System.Windows.Forms.ToolStripSeparator BindingNavigatorSeparator;
        internal System.Windows.Forms.ToolStripTextBox BindingNavigatorPositionItem;
        internal System.Windows.Forms.ToolStripSeparator BindingNavigatorSeparator1;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMoveNextItem;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMoveLastItem;
        internal System.Windows.Forms.ToolStripSeparator BindingNavigatorSeparator2;
        internal System.Windows.Forms.ToolStripButton btnNovoRegistro;
        internal System.Windows.Forms.ToolStripButton btnExcluir;
        internal System.Windows.Forms.ToolStripButton btnSalvar;
        internal System.Windows.Forms.ToolStripButton btnAlterar;
        internal System.Windows.Forms.ToolStripButton btnCancelar;
        internal System.Windows.Forms.ToolStripButton btnSair;
        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage Dados;
        internal System.Windows.Forms.DataGridView dgvDespesa;
        internal System.Windows.Forms.TabPage Detalhes;
        internal System.Windows.Forms.TextBox txtValorDespesa;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtDataDespesa;
        internal System.Windows.Forms.TextBox txtId;
        internal System.Windows.Forms.Label lblCidade;
        internal System.Windows.Forms.Label lblId;
        private System.Windows.Forms.RichTextBox txtObsDespesa;
        internal System.Windows.Forms.Label label2;
    }
}