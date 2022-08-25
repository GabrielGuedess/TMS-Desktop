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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroClientes));
            this.panel17 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panelPessoaJuridica = new System.Windows.Forms.Panel();
            this.pessoaJuridica = new System.Windows.Forms.RadioButton();
            this.panelPessoaFisica = new System.Windows.Forms.Panel();
            this.pessoaFisica = new System.Windows.Forms.RadioButton();
            this.ClienteCPF = new Interface.UserControl1();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.panelSerch = new Interface.Properties.PanelBorderRoundedOnLeft();
            this.labelTypePerson = new System.Windows.Forms.Label();
            this.mkBoxCdClientSearch = new Interface.Properties.masckedboxTemplete();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ClienteCNPJ = new Interface.ClienteCNPJ();
            this.panel17.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelPessoaJuridica.SuspendLayout();
            this.panelPessoaFisica.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.panelSerch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.Transparent;
            this.panel17.Controls.Add(this.tableLayoutPanel2);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel17.Location = new System.Drawing.Point(0, 0);
            this.panel17.Margin = new System.Windows.Forms.Padding(0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(975, 62);
            this.panel17.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panelPessoaJuridica, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panelPessoaFisica, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.pessoaJuridica.Text = "Pessoa Jurídica";
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
            this.ClienteCPF.Location = new System.Drawing.Point(0, 124);
            this.ClienteCPF.Margin = new System.Windows.Forms.Padding(0);
            this.ClienteCPF.Name = "ClienteCPF";
            this.ClienteCPF.Size = new System.Drawing.Size(975, 653);
            this.ClienteCPF.TabIndex = 6;
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.Transparent;
            this.searchPanel.Controls.Add(this.panelSerch);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchPanel.Location = new System.Drawing.Point(0, 62);
            this.searchPanel.Margin = new System.Windows.Forms.Padding(0);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Padding = new System.Windows.Forms.Padding(0, 13, 0, 13);
            this.searchPanel.Size = new System.Drawing.Size(975, 62);
            this.searchPanel.TabIndex = 8;
            // 
            // panelSerch
            // 
            this.panelSerch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelSerch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.panelSerch.Controls.Add(this.labelTypePerson);
            this.panelSerch.Controls.Add(this.mkBoxCdClientSearch);
            this.panelSerch.Controls.Add(this.pictureBox3);
            this.panelSerch.Location = new System.Drawing.Point(314, 13);
            this.panelSerch.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panelSerch.Name = "panelSerch";
            this.panelSerch.Size = new System.Drawing.Size(347, 36);
            this.panelSerch.TabIndex = 2;
            this.panelSerch.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSerch_Paint);
            // 
            // labelTypePerson
            // 
            this.labelTypePerson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTypePerson.AutoSize = true;
            this.labelTypePerson.BackColor = System.Drawing.Color.Transparent;
            this.labelTypePerson.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTypePerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(101)))));
            this.labelTypePerson.Location = new System.Drawing.Point(35, 7);
            this.labelTypePerson.Margin = new System.Windows.Forms.Padding(10, 7, 0, 6);
            this.labelTypePerson.Name = "labelTypePerson";
            this.labelTypePerson.Size = new System.Drawing.Size(37, 21);
            this.labelTypePerson.TabIndex = 4;
            this.labelTypePerson.Text = "CPF";
            this.labelTypePerson.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSerch_Paint);
            // 
            // mkBoxCdClientSearch
            // 
            this.mkBoxCdClientSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mkBoxCdClientSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.mkBoxCdClientSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mkBoxCdClientSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mkBoxCdClientSearch.ForeColor = System.Drawing.Color.White;
            this.mkBoxCdClientSearch.Location = new System.Drawing.Point(82, 7);
            this.mkBoxCdClientSearch.Margin = new System.Windows.Forms.Padding(10, 6, 10, 5);
            this.mkBoxCdClientSearch.Name = "mkBoxCdClientSearch";
            this.mkBoxCdClientSearch.Size = new System.Drawing.Size(224, 22);
            this.mkBoxCdClientSearch.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(10, 12);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(15, 15);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // ClienteCNPJ
            // 
            this.ClienteCNPJ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClienteCNPJ.BackColor = System.Drawing.Color.Transparent;
            this.ClienteCNPJ.Location = new System.Drawing.Point(0, 124);
            this.ClienteCNPJ.Margin = new System.Windows.Forms.Padding(0);
            this.ClienteCNPJ.Name = "ClienteCNPJ";
            this.ClienteCNPJ.Size = new System.Drawing.Size(975, 653);
            this.ClienteCNPJ.TabIndex = 4;
            // 
            // CadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.ClienteCNPJ);
            this.Controls.Add(this.ClienteCPF);
            this.Controls.Add(this.panel17);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CadastroClientes";
            this.Size = new System.Drawing.Size(975, 715);
            this.Load += new System.EventHandler(this.CadastroClientes_Load);
            this.Resize += new System.EventHandler(this.CadastroClientes_Resize);
            this.panel17.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panelPessoaJuridica.ResumeLayout(false);
            this.panelPessoaJuridica.PerformLayout();
            this.panelPessoaFisica.ResumeLayout(false);
            this.panelPessoaFisica.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.panelSerch.ResumeLayout(false);
            this.panelSerch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private Panel searchPanel;
        private Properties.PanelBorderRoundedOnLeft panelSerch;
        private PictureBox pictureBox3;
        private ClienteCNPJ ClienteCNPJ;
        private Properties.masckedboxTemplete mkBoxCdClientSearch;
        private Label labelTypePerson;
    }
}
