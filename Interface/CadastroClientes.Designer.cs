namespace Interface
{
    partial class CadastroClientes
    {
        private System.ComponentModel.IContainer components = null;
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel17 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panelPessoaJuridica = new System.Windows.Forms.Panel();
            this.pessoaJuridica = new System.Windows.Forms.RadioButton();
            this.panelPessoaFisica = new System.Windows.Forms.Panel();
            this.pessoaFisica = new System.Windows.Forms.RadioButton();
            this.ClienteCPF = new Interface.UserControl1();
            this.ClienteCNPJ = new Interface.ClienteCNPJ();
            this.panel17.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelPessoaJuridica.SuspendLayout();
            this.panelPessoaFisica.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel17
            // 
            this.panel17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel17.BackColor = System.Drawing.Color.Transparent;
            this.panel17.Controls.Add(this.tableLayoutPanel2);
            this.panel17.Location = new System.Drawing.Point(0, 0);
            this.panel17.Margin = new System.Windows.Forms.Padding(0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(975, 62);
            this.panel17.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panelPessoaJuridica, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panelPessoaFisica, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(975, 62);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panelPessoaJuridica
            // 
            this.panelPessoaJuridica.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPessoaJuridica.BackColor = System.Drawing.Color.Transparent;
            this.panelPessoaJuridica.Controls.Add(this.pessoaJuridica);
            this.panelPessoaJuridica.Location = new System.Drawing.Point(487, 0);
            this.panelPessoaJuridica.Margin = new System.Windows.Forms.Padding(0);
            this.panelPessoaJuridica.Name = "panelPessoaJuridica";
            this.panelPessoaJuridica.Size = new System.Drawing.Size(488, 62);
            this.panelPessoaJuridica.TabIndex = 4;
            this.panelPessoaJuridica.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPessoaJuridica_Paint);
            // 
            // pessoaJuridica
            // 
            this.pessoaJuridica.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pessoaJuridica.AutoSize = true;
            this.pessoaJuridica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pessoaJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.pessoaJuridica.ForeColor = System.Drawing.Color.White;
            this.pessoaJuridica.Location = new System.Drawing.Point(186, 19);
            this.pessoaJuridica.Margin = new System.Windows.Forms.Padding(0, 19, 0, 0);
            this.pessoaJuridica.Name = "pessoaJuridica";
            this.pessoaJuridica.Size = new System.Drawing.Size(138, 24);
            this.pessoaJuridica.TabIndex = 3;
            this.pessoaJuridica.Text = "Pessoa Juridica";
            this.pessoaJuridica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pessoaJuridica.UseVisualStyleBackColor = true;
            this.pessoaJuridica.CheckedChanged += new System.EventHandler(this.pessoaJuridica_CheckedChanged);
            // 
            // panelPessoaFisica
            // 
            this.panelPessoaFisica.BackColor = System.Drawing.Color.Transparent;
            this.panelPessoaFisica.Controls.Add(this.pessoaFisica);
            this.panelPessoaFisica.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPessoaFisica.Location = new System.Drawing.Point(0, 0);
            this.panelPessoaFisica.Margin = new System.Windows.Forms.Padding(0);
            this.panelPessoaFisica.Name = "panelPessoaFisica";
            this.panelPessoaFisica.Size = new System.Drawing.Size(487, 62);
            this.panelPessoaFisica.TabIndex = 3;
            this.panelPessoaFisica.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPessoaFisica_Paint);
            // 
            // pessoaFisica
            // 
            this.pessoaFisica.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pessoaFisica.AutoSize = true;
            this.pessoaFisica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pessoaFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.pessoaFisica.ForeColor = System.Drawing.Color.White;
            this.pessoaFisica.Location = new System.Drawing.Point(173, 19);
            this.pessoaFisica.Margin = new System.Windows.Forms.Padding(0, 19, 0, 0);
            this.pessoaFisica.Name = "pessoaFisica";
            this.pessoaFisica.Size = new System.Drawing.Size(125, 24);
            this.pessoaFisica.TabIndex = 2;
            this.pessoaFisica.Text = "Pessoa Física";
            this.pessoaFisica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pessoaFisica.UseVisualStyleBackColor = true;
            this.pessoaFisica.CheckedChanged += new System.EventHandler(this.pessoaFisica_CheckedChanged);
            // 
            // ClienteCPF
            // 
            this.ClienteCPF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClienteCPF.BackColor = System.Drawing.Color.Transparent;
            this.ClienteCPF.Location = new System.Drawing.Point(0, 62);
            this.ClienteCPF.Margin = new System.Windows.Forms.Padding(0);
            this.ClienteCPF.Name = "ClienteCPF";
            this.ClienteCPF.Size = new System.Drawing.Size(975, 476);
            this.ClienteCPF.TabIndex = 6;
            // 
            // ClienteCNPJ
            // 
            this.ClienteCNPJ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClienteCNPJ.BackColor = System.Drawing.Color.Transparent;
            this.ClienteCNPJ.Location = new System.Drawing.Point(0, 62);
            this.ClienteCNPJ.Margin = new System.Windows.Forms.Padding(0);
            this.ClienteCNPJ.Name = "ClienteCNPJ";
            this.ClienteCNPJ.Size = new System.Drawing.Size(975, 637);
            this.ClienteCNPJ.TabIndex = 4;
            // 
            // CadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ClienteCNPJ);
            this.Controls.Add(this.ClienteCPF);
            this.Controls.Add(this.panel17);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CadastroClientes";
            this.Size = new System.Drawing.Size(975, 538);
            this.Load += new System.EventHandler(this.CadastroClientes_Load);
            this.panel17.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panelPessoaJuridica.ResumeLayout(false);
            this.panelPessoaJuridica.PerformLayout();
            this.panelPessoaFisica.ResumeLayout(false);
            this.panelPessoaFisica.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel17;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panelPessoaJuridica;
        private RadioButton pessoaJuridica;
        private Panel panelPessoaFisica;
        private RadioButton pessoaFisica;
        private UserControl1 ClienteCPF;
        private ClienteCNPJ ClienteCNPJ;
    }
}
