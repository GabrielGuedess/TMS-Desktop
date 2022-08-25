namespace Interface
{
    partial class Overview
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overview));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelSerch = new Interface.Properties.PanelBorderRoundedOnLeft();
            this.maskInput = new Interface.Properties.masckedboxTemplete();
            this.panel17 = new System.Windows.Forms.Panel();
            this.contentOverview = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelButton = new System.Windows.Forms.Panel();
            this.buscar = new System.Windows.Forms.Button();
            this.panel51 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panelPessoaJuridica = new System.Windows.Forms.Panel();
            this.pessoaJuridica = new System.Windows.Forms.RadioButton();
            this.panelPessoaFisica = new System.Windows.Forms.Panel();
            this.pessoaFisica = new System.Windows.Forms.RadioButton();
            this.panelContainerRadio = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelCNPJ = new System.Windows.Forms.Panel();
            this.CNPJ = new System.Windows.Forms.RadioButton();
            this.panelCPF = new System.Windows.Forms.Panel();
            this.CPF = new System.Windows.Forms.RadioButton();
            this.typeData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelSerch.SuspendLayout();
            this.panel17.SuspendLayout();
            this.contentOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelButton.SuspendLayout();
            this.panel51.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelPessoaJuridica.SuspendLayout();
            this.panelPessoaFisica.SuspendLayout();
            this.panelContainerRadio.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelCNPJ.SuspendLayout();
            this.panelCPF.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(10, 10);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(15, 15);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // panelSerch
            // 
            this.panelSerch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelSerch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.panelSerch.Controls.Add(this.typeData);
            this.panelSerch.Controls.Add(this.maskInput);
            this.panelSerch.Controls.Add(this.pictureBox3);
            this.panelSerch.Location = new System.Drawing.Point(326, 13);
            this.panelSerch.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panelSerch.Name = "panelSerch";
            this.panelSerch.Size = new System.Drawing.Size(316, 36);
            this.panelSerch.TabIndex = 2;
            this.panelSerch.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSerch_Paint);
            // 
            // maskInput
            // 
            this.maskInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.maskInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.maskInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskInput.ForeColor = System.Drawing.Color.White;
            this.maskInput.Location = new System.Drawing.Point(84, 7);
            this.maskInput.Margin = new System.Windows.Forms.Padding(10, 6, 10, 5);
            this.maskInput.Name = "maskInput";
            this.maskInput.Size = new System.Drawing.Size(222, 22);
            this.maskInput.TabIndex = 3;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.Transparent;
            this.panel17.Controls.Add(this.panelSerch);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel17.Location = new System.Drawing.Point(0, 62);
            this.panel17.Margin = new System.Windows.Forms.Padding(0);
            this.panel17.Name = "panel17";
            this.panel17.Padding = new System.Windows.Forms.Padding(0, 13, 0, 13);
            this.panel17.Size = new System.Drawing.Size(975, 62);
            this.panel17.TabIndex = 6;
            this.panel17.Paint += new System.Windows.Forms.PaintEventHandler(this.panel17_Paint);
            // 
            // contentOverview
            // 
            this.contentOverview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentOverview.AutoScroll = true;
            this.contentOverview.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.contentOverview.BackColor = System.Drawing.Color.Transparent;
            this.contentOverview.Controls.Add(this.dataGridView1);
            this.contentOverview.Controls.Add(this.panelButton);
            this.contentOverview.Location = new System.Drawing.Point(0, 124);
            this.contentOverview.Margin = new System.Windows.Forms.Padding(0);
            this.contentOverview.Name = "contentOverview";
            this.contentOverview.Padding = new System.Windows.Forms.Padding(40);
            this.contentOverview.Size = new System.Drawing.Size(975, 688);
            this.contentOverview.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 40);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(895, 426);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.Resize += new System.EventHandler(this.dataGridView1_Resize);
            // 
            // panelButton
            // 
            this.panelButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelButton.BackColor = System.Drawing.Color.Transparent;
            this.panelButton.Controls.Add(this.buscar);
            this.panelButton.Controls.Add(this.panel51);
            this.panelButton.Location = new System.Drawing.Point(0, 566);
            this.panelButton.Margin = new System.Windows.Forms.Padding(0, 100, 0, 0);
            this.panelButton.Name = "panelButton";
            this.panelButton.Padding = new System.Windows.Forms.Padding(40, 0, 40, 0);
            this.panelButton.Size = new System.Drawing.Size(975, 50);
            this.panelButton.TabIndex = 5;
            // 
            // buscar
            // 
            this.buscar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(199)))));
            this.buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscar.FlatAppearance.BorderSize = 0;
            this.buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.buscar.ForeColor = System.Drawing.Color.White;
            this.buscar.Location = new System.Drawing.Point(755, 0);
            this.buscar.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(180, 50);
            this.buscar.TabIndex = 9;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = false;
            this.buscar.Paint += new System.Windows.Forms.PaintEventHandler(this.buscar_Paint);
            // 
            // panel51
            // 
            this.panel51.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel51.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            this.panel51.Controls.Add(this.button10);
            this.panel51.Location = new System.Drawing.Point(8025, 0);
            this.panel51.Margin = new System.Windows.Forms.Padding(0);
            this.panel51.Name = "panel51";
            this.panel51.Size = new System.Drawing.Size(200, 0);
            this.panel51.TabIndex = 1;
            // 
            // button10
            // 
            this.button10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button10.BackColor = System.Drawing.Color.Transparent;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(0, 0);
            this.button10.Margin = new System.Windows.Forms.Padding(0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(200, 0);
            this.button10.TabIndex = 1;
            this.button10.Text = "Salvar";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panelPessoaJuridica, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panelPessoaJuridica
            // 
            this.panelPessoaJuridica.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPessoaJuridica.BackColor = System.Drawing.Color.Transparent;
            this.panelPessoaJuridica.Controls.Add(this.pessoaJuridica);
            this.panelPessoaJuridica.Location = new System.Drawing.Point(100, 0);
            this.panelPessoaJuridica.Margin = new System.Windows.Forms.Padding(0);
            this.panelPessoaJuridica.Name = "panelPessoaJuridica";
            this.panelPessoaJuridica.Size = new System.Drawing.Size(100, 62);
            this.panelPessoaJuridica.TabIndex = 4;
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
            // 
            // panelPessoaFisica
            // 
            this.panelPessoaFisica.BackColor = System.Drawing.Color.Transparent;
            this.panelPessoaFisica.Controls.Add(this.pessoaFisica);
            this.panelPessoaFisica.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPessoaFisica.Location = new System.Drawing.Point(0, 0);
            this.panelPessoaFisica.Margin = new System.Windows.Forms.Padding(0);
            this.panelPessoaFisica.Name = "panelPessoaFisica";
            this.panelPessoaFisica.Size = new System.Drawing.Size(100, 62);
            this.panelPessoaFisica.TabIndex = 3;
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
            // 
            // panelContainerRadio
            // 
            this.panelContainerRadio.BackColor = System.Drawing.Color.Transparent;
            this.panelContainerRadio.Controls.Add(this.tableLayoutPanel1);
            this.panelContainerRadio.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContainerRadio.Location = new System.Drawing.Point(0, 0);
            this.panelContainerRadio.Margin = new System.Windows.Forms.Padding(0);
            this.panelContainerRadio.Name = "panelContainerRadio";
            this.panelContainerRadio.Size = new System.Drawing.Size(975, 62);
            this.panelContainerRadio.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panelCNPJ, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelCPF, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(975, 62);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelCNPJ
            // 
            this.panelCNPJ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCNPJ.BackColor = System.Drawing.Color.Transparent;
            this.panelCNPJ.Controls.Add(this.CNPJ);
            this.panelCNPJ.Location = new System.Drawing.Point(487, 0);
            this.panelCNPJ.Margin = new System.Windows.Forms.Padding(0);
            this.panelCNPJ.Name = "panelCNPJ";
            this.panelCNPJ.Size = new System.Drawing.Size(488, 62);
            this.panelCNPJ.TabIndex = 4;
            this.panelCNPJ.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCNPJ_Paint);
            // 
            // CNPJ
            // 
            this.CNPJ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CNPJ.AutoSize = true;
            this.CNPJ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CNPJ.ForeColor = System.Drawing.Color.White;
            this.CNPJ.Location = new System.Drawing.Point(186, 19);
            this.CNPJ.Margin = new System.Windows.Forms.Padding(0, 19, 0, 0);
            this.CNPJ.Name = "CNPJ";
            this.CNPJ.Size = new System.Drawing.Size(138, 24);
            this.CNPJ.TabIndex = 3;
            this.CNPJ.Text = "Pessoa Jurídica";
            this.CNPJ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CNPJ.UseVisualStyleBackColor = true;
            this.CNPJ.CheckedChanged += new System.EventHandler(this.CNPJ_CheckedChanged);
            // 
            // panelCPF
            // 
            this.panelCPF.BackColor = System.Drawing.Color.Transparent;
            this.panelCPF.Controls.Add(this.CPF);
            this.panelCPF.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCPF.Location = new System.Drawing.Point(0, 0);
            this.panelCPF.Margin = new System.Windows.Forms.Padding(0);
            this.panelCPF.Name = "panelCPF";
            this.panelCPF.Size = new System.Drawing.Size(487, 62);
            this.panelCPF.TabIndex = 3;
            this.panelCPF.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCPF_Paint);
            // 
            // CPF
            // 
            this.CPF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CPF.AutoSize = true;
            this.CPF.Checked = true;
            this.CPF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CPF.ForeColor = System.Drawing.Color.White;
            this.CPF.Location = new System.Drawing.Point(173, 19);
            this.CPF.Margin = new System.Windows.Forms.Padding(0, 19, 0, 0);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(125, 24);
            this.CPF.TabIndex = 2;
            this.CPF.TabStop = true;
            this.CPF.Text = "Pessoa Física";
            this.CPF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CPF.UseVisualStyleBackColor = true;
            this.CPF.CheckedChanged += new System.EventHandler(this.CPF_CheckedChanged);
            // 
            // typeData
            // 
            this.typeData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.typeData.AutoSize = true;
            this.typeData.BackColor = System.Drawing.Color.Transparent;
            this.typeData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.typeData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(101)))));
            this.typeData.Location = new System.Drawing.Point(35, 7);
            this.typeData.Margin = new System.Windows.Forms.Padding(10, 7, 0, 6);
            this.typeData.Name = "typeData";
            this.typeData.Size = new System.Drawing.Size(37, 21);
            this.typeData.TabIndex = 3;
            this.typeData.Text = "CPF";
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.panelContainerRadio);
            this.Controls.Add(this.contentOverview);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Overview";
            this.Size = new System.Drawing.Size(975, 806);
            this.Resize += new System.EventHandler(this.Overview_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelSerch.ResumeLayout(false);
            this.panelSerch.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.contentOverview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelButton.ResumeLayout(false);
            this.panel51.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panelPessoaJuridica.ResumeLayout(false);
            this.panelPessoaJuridica.PerformLayout();
            this.panelPessoaFisica.ResumeLayout(false);
            this.panelPessoaFisica.PerformLayout();
            this.panelContainerRadio.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelCNPJ.ResumeLayout(false);
            this.panelCNPJ.PerformLayout();
            this.panelCPF.ResumeLayout(false);
            this.panelCPF.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox3;
        private Properties.PanelBorderRoundedOnLeft panelSerch;
        private Panel panel17;
        private Panel contentOverview;
        private DataGridView dataGridView1;
        private Panel panelButton;
        private Panel panel51;
        private Button button10;
        private Button buscar;
        private Properties.masckedboxTemplete maskInput;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panelPessoaJuridica;
        private RadioButton pessoaJuridica;
        private Panel panelPessoaFisica;
        private RadioButton pessoaFisica;
        private Panel panelContainerRadio;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelCNPJ;
        private RadioButton CNPJ;
        private Panel panelCPF;
        private RadioButton CPF;
        private Label typeData;
    }
}
