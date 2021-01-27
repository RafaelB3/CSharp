namespace Aula8
{
    partial class Form1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnBranco = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnPares = new System.Windows.Forms.Button();
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(237, 96);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnBranco
            // 
            this.btnBranco.Location = new System.Drawing.Point(12, 114);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(75, 23);
            this.btnBranco.TabIndex = 1;
            this.btnBranco.Text = "Branco";
            this.btnBranco.UseVisualStyleBackColor = true;
            this.btnBranco.Click += new System.EventHandler(this.btnBranco_Click);
            // 
            // btnR
            // 
            this.btnR.Location = new System.Drawing.Point(93, 114);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(75, 23);
            this.btnR.TabIndex = 2;
            this.btnR.Text = "R";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btnPares
            // 
            this.btnPares.Location = new System.Drawing.Point(174, 114);
            this.btnPares.Name = "btnPares";
            this.btnPares.Size = new System.Drawing.Size(75, 23);
            this.btnPares.TabIndex = 3;
            this.btnPares.Text = "Pares";
            this.btnPares.UseVisualStyleBackColor = true;
            this.btnPares.Click += new System.EventHandler(this.btnPares_Click);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(256, 13);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 20);
            this.txtN.TabIndex = 4;
            // 
            // btnH
            // 
            this.btnH.Location = new System.Drawing.Point(268, 39);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(75, 23);
            this.btnH.TabIndex = 5;
            this.btnH.Text = "H";
            this.btnH.UseVisualStyleBackColor = true;
            this.btnH.Click += new System.EventHandler(this.btnH_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 457);
            this.Controls.Add(this.btnH);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.btnPares);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnBranco);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnBranco;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnPares;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnH;

    }
}

