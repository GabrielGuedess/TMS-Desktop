namespace Interface
{
    partial class CadastroSinistros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroSinistros));
            this.searchPanel = new System.Windows.Forms.Panel();
            this.panelSerch = new Interface.TemplateComponents.PanelBorderRoundedOnLeft();
            this.typeData = new System.Windows.Forms.Label();
            this.cod = new Interface.TemplateComponents.TextBoxOnlyNum_Letters();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.contentSinistros = new System.Windows.Forms.Panel();
            this.tableSinistro = new System.Windows.Forms.TableLayoutPanel();
            this.panelCPF = new System.Windows.Forms.Panel();
            this.SubpanelCPF = new System.Windows.Forms.Panel();
            this.comboTipoSinistro = new System.Windows.Forms.ComboBox();
            this.labelCPFClient = new System.Windows.Forms.Label();
            this.panelNomeClient = new System.Windows.Forms.Panel();
            this.subpanelNomeClient = new System.Windows.Forms.Panel();
            this.panelDateTimerClient = new Interface.TemplateComponents.PanelBorderRounded();
            this.tbDescricaoSinistro = new Interface.TemplateComponents.TextBoxOnlyNum_Letters();
            this.labelDescricaoSinistro = new System.Windows.Forms.Label();
            this.templatePanel1 = new Interface.TemplateComponents.TemplatePanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelBorderRounded1 = new Interface.TemplateComponents.PanelBorderRounded();
            this.tbCod = new Interface.TemplateComponents.TextBoxOnlyNum();
            this.label1 = new System.Windows.Forms.Label();
            this.panelButton = new System.Windows.Forms.Panel();
            this.buscarCodigo = new System.Windows.Forms.Button();
            this.cadastrarSinistro = new System.Windows.Forms.Button();
            this.panel51 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.searchPanel.SuspendLayout();
            this.panelSerch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.contentSinistros.SuspendLayout();
            this.tableSinistro.SuspendLayout();
            this.panelCPF.SuspendLayout();
            this.SubpanelCPF.SuspendLayout();
            this.panelNomeClient.SuspendLayout();
            this.subpanelNomeClient.SuspendLayout();
            this.panelDateTimerClient.SuspendLayout();
            this.templatePanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelBorderRounded1.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.panel51.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.Transparent;
            this.searchPanel.Controls.Add(this.panelSerch);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchPanel.Location = new System.Drawing.Point(0, 0);
            this.searchPanel.Margin = new System.Windows.Forms.Padding(0);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Padding = new System.Windows.Forms.Padding(0, 13, 0, 13);
            this.searchPanel.Size = new System.Drawing.Size(975, 62);
            this.searchPanel.TabIndex = 14;
            // 
            // panelSerch
            // 
            this.panelSerch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelSerch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.panelSerch.Controls.Add(this.typeData);
            this.panelSerch.Controls.Add(this.cod);
            this.panelSerch.Controls.Add(this.pictureBox3);
            this.panelSerch.Location = new System.Drawing.Point(311, 13);
            this.panelSerch.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panelSerch.Name = "panelSerch";
            this.panelSerch.Size = new System.Drawing.Size(347, 36);
            this.panelSerch.TabIndex = 2;
            this.panelSerch.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSerch_Paint);
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
            this.typeData.Size = new System.Drawing.Size(60, 21);
            this.typeData.TabIndex = 4;
            this.typeData.Text = "Código";
            // 
            // cod
            // 
            this.cod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.cod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cod.ForeColor = System.Drawing.Color.White;
            this.cod.Location = new System.Drawing.Point(105, 7);
            this.cod.Margin = new System.Windows.Forms.Padding(10, 6, 10, 5);
            this.cod.Name = "cod";
            this.cod.Size = new System.Drawing.Size(232, 22);
            this.cod.TabIndex = 2;
            this.cod.TextChanged += new System.EventHandler(this.cod_TextChanged);
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
            // contentSinistros
            // 
            this.contentSinistros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentSinistros.AutoScroll = true;
            this.contentSinistros.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.contentSinistros.BackColor = System.Drawing.Color.Transparent;
            this.contentSinistros.Controls.Add(this.tableSinistro);
            this.contentSinistros.Controls.Add(this.panelButton);
            this.contentSinistros.Location = new System.Drawing.Point(0, 62);
            this.contentSinistros.Margin = new System.Windows.Forms.Padding(0);
            this.contentSinistros.Name = "contentSinistros";
            this.contentSinistros.Padding = new System.Windows.Forms.Padding(40);
            this.contentSinistros.Size = new System.Drawing.Size(975, 312);
            this.contentSinistros.TabIndex = 15;
            // 
            // tableSinistro
            // 
            this.tableSinistro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableSinistro.ColumnCount = 3;
            this.tableSinistro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34444F));
            this.tableSinistro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34446F));
            this.tableSinistro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.31111F));
            this.tableSinistro.Controls.Add(this.panelCPF, 1, 0);
            this.tableSinistro.Controls.Add(this.panelNomeClient, 2, 0);
            this.tableSinistro.Controls.Add(this.templatePanel1, 0, 0);
            this.tableSinistro.Location = new System.Drawing.Point(40, 40);
            this.tableSinistro.Margin = new System.Windows.Forms.Padding(0);
            this.tableSinistro.Name = "tableSinistro";
            this.tableSinistro.RowCount = 1;
            this.tableSinistro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableSinistro.Size = new System.Drawing.Size(895, 100);
            this.tableSinistro.TabIndex = 12;
            // 
            // panelCPF
            // 
            this.panelCPF.BackColor = System.Drawing.Color.Transparent;
            this.panelCPF.Controls.Add(this.SubpanelCPF);
            this.panelCPF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCPF.Location = new System.Drawing.Point(298, 0);
            this.panelCPF.Margin = new System.Windows.Forms.Padding(0);
            this.panelCPF.Name = "panelCPF";
            this.panelCPF.Padding = new System.Windows.Forms.Padding(20, 20, 20, 10);
            this.panelCPF.Size = new System.Drawing.Size(298, 100);
            this.panelCPF.TabIndex = 0;
            // 
            // SubpanelCPF
            // 
            this.SubpanelCPF.BackColor = System.Drawing.Color.Transparent;
            this.SubpanelCPF.Controls.Add(this.comboTipoSinistro);
            this.SubpanelCPF.Controls.Add(this.labelCPFClient);
            this.SubpanelCPF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubpanelCPF.Location = new System.Drawing.Point(20, 20);
            this.SubpanelCPF.Margin = new System.Windows.Forms.Padding(0);
            this.SubpanelCPF.Name = "SubpanelCPF";
            this.SubpanelCPF.Size = new System.Drawing.Size(258, 70);
            this.SubpanelCPF.TabIndex = 7;
            // 
            // comboTipoSinistro
            // 
            this.comboTipoSinistro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboTipoSinistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(18)))));
            this.comboTipoSinistro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoSinistro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboTipoSinistro.ForeColor = System.Drawing.Color.White;
            this.comboTipoSinistro.FormattingEnabled = true;
            this.comboTipoSinistro.Items.AddRange(new object[] {
            "Pequena monta. ",
            "Média monta.",
            "Grande monta.",
            "Roubo e furto.",
            "Acidentes de trânsito.",
            "Danos a terceiros. ",
            "Causas naturais."});
            this.comboTipoSinistro.Location = new System.Drawing.Point(5, 35);
            this.comboTipoSinistro.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.comboTipoSinistro.Name = "comboTipoSinistro";
            this.comboTipoSinistro.Size = new System.Drawing.Size(248, 29);
            this.comboTipoSinistro.TabIndex = 5;
            // 
            // labelCPFClient
            // 
            this.labelCPFClient.AutoSize = true;
            this.labelCPFClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelCPFClient.ForeColor = System.Drawing.Color.White;
            this.labelCPFClient.Location = new System.Drawing.Point(5, 5);
            this.labelCPFClient.Margin = new System.Windows.Forms.Padding(5, 0, 0, 15);
            this.labelCPFClient.Name = "labelCPFClient";
            this.labelCPFClient.Size = new System.Drawing.Size(107, 17);
            this.labelCPFClient.TabIndex = 0;
            this.labelCPFClient.Text = "Tipo de Sinistro";
            // 
            // panelNomeClient
            // 
            this.panelNomeClient.BackColor = System.Drawing.Color.Transparent;
            this.panelNomeClient.Controls.Add(this.subpanelNomeClient);
            this.panelNomeClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNomeClient.Location = new System.Drawing.Point(596, 0);
            this.panelNomeClient.Margin = new System.Windows.Forms.Padding(0);
            this.panelNomeClient.Name = "panelNomeClient";
            this.panelNomeClient.Padding = new System.Windows.Forms.Padding(20, 20, 20, 10);
            this.panelNomeClient.Size = new System.Drawing.Size(299, 100);
            this.panelNomeClient.TabIndex = 1;
            // 
            // subpanelNomeClient
            // 
            this.subpanelNomeClient.BackColor = System.Drawing.Color.Transparent;
            this.subpanelNomeClient.Controls.Add(this.panelDateTimerClient);
            this.subpanelNomeClient.Controls.Add(this.labelDescricaoSinistro);
            this.subpanelNomeClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subpanelNomeClient.Location = new System.Drawing.Point(20, 20);
            this.subpanelNomeClient.Margin = new System.Windows.Forms.Padding(0);
            this.subpanelNomeClient.Name = "subpanelNomeClient";
            this.subpanelNomeClient.Size = new System.Drawing.Size(259, 70);
            this.subpanelNomeClient.TabIndex = 8;
            // 
            // panelDateTimerClient
            // 
            this.panelDateTimerClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDateTimerClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.panelDateTimerClient.Controls.Add(this.tbDescricaoSinistro);
            this.panelDateTimerClient.Location = new System.Drawing.Point(5, 37);
            this.panelDateTimerClient.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panelDateTimerClient.Name = "panelDateTimerClient";
            this.panelDateTimerClient.Size = new System.Drawing.Size(249, 33);
            this.panelDateTimerClient.TabIndex = 2;
            // 
            // tbDescricaoSinistro
            // 
            this.tbDescricaoSinistro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescricaoSinistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.tbDescricaoSinistro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDescricaoSinistro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDescricaoSinistro.ForeColor = System.Drawing.Color.White;
            this.tbDescricaoSinistro.Location = new System.Drawing.Point(10, 6);
            this.tbDescricaoSinistro.Margin = new System.Windows.Forms.Padding(10, 6, 10, 5);
            this.tbDescricaoSinistro.Name = "tbDescricaoSinistro";
            this.tbDescricaoSinistro.Size = new System.Drawing.Size(229, 22);
            this.tbDescricaoSinistro.TabIndex = 1;
            // 
            // labelDescricaoSinistro
            // 
            this.labelDescricaoSinistro.AutoSize = true;
            this.labelDescricaoSinistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelDescricaoSinistro.ForeColor = System.Drawing.Color.White;
            this.labelDescricaoSinistro.Location = new System.Drawing.Point(5, 5);
            this.labelDescricaoSinistro.Margin = new System.Windows.Forms.Padding(5, 0, 0, 15);
            this.labelDescricaoSinistro.Name = "labelDescricaoSinistro";
            this.labelDescricaoSinistro.Size = new System.Drawing.Size(142, 17);
            this.labelDescricaoSinistro.TabIndex = 0;
            this.labelDescricaoSinistro.Text = "Descrição do Sinistro";
            // 
            // templatePanel1
            // 
            this.templatePanel1.Controls.Add(this.panel1);
            this.templatePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.templatePanel1.Location = new System.Drawing.Point(0, 0);
            this.templatePanel1.Margin = new System.Windows.Forms.Padding(0);
            this.templatePanel1.Name = "templatePanel1";
            this.templatePanel1.Padding = new System.Windows.Forms.Padding(20, 20, 20, 10);
            this.templatePanel1.Size = new System.Drawing.Size(298, 100);
            this.templatePanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panelBorderRounded1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 70);
            this.panel1.TabIndex = 8;
            // 
            // panelBorderRounded1
            // 
            this.panelBorderRounded1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBorderRounded1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.panelBorderRounded1.Controls.Add(this.tbCod);
            this.panelBorderRounded1.Location = new System.Drawing.Point(5, 35);
            this.panelBorderRounded1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panelBorderRounded1.Name = "panelBorderRounded1";
            this.panelBorderRounded1.Size = new System.Drawing.Size(254, 33);
            this.panelBorderRounded1.TabIndex = 1;
            // 
            // tbCod
            // 
            this.tbCod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.tbCod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCod.Enabled = false;
            this.tbCod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCod.ForeColor = System.Drawing.Color.White;
            this.tbCod.Location = new System.Drawing.Point(10, 7);
            this.tbCod.Margin = new System.Windows.Forms.Padding(10, 6, 10, 5);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(233, 22);
            this.tbCod.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 0, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código do Sinistro";
            // 
            // panelButton
            // 
            this.panelButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelButton.BackColor = System.Drawing.Color.Transparent;
            this.panelButton.Controls.Add(this.buscarCodigo);
            this.panelButton.Controls.Add(this.cadastrarSinistro);
            this.panelButton.Controls.Add(this.panel51);
            this.panelButton.Location = new System.Drawing.Point(0, 240);
            this.panelButton.Margin = new System.Windows.Forms.Padding(0, 100, 0, 0);
            this.panelButton.Name = "panelButton";
            this.panelButton.Padding = new System.Windows.Forms.Padding(40, 0, 40, 0);
            this.panelButton.Size = new System.Drawing.Size(975, 50);
            this.panelButton.TabIndex = 5;
            // 
            // buscarCodigo
            // 
            this.buscarCodigo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buscarCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(199)))));
            this.buscarCodigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarCodigo.FlatAppearance.BorderSize = 0;
            this.buscarCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.buscarCodigo.ForeColor = System.Drawing.Color.White;
            this.buscarCodigo.Location = new System.Drawing.Point(535, 0);
            this.buscarCodigo.Margin = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.buscarCodigo.Name = "buscarCodigo";
            this.buscarCodigo.Size = new System.Drawing.Size(180, 50);
            this.buscarCodigo.TabIndex = 15;
            this.buscarCodigo.Text = "Buscar Código";
            this.buscarCodigo.UseVisualStyleBackColor = false;
            this.buscarCodigo.Visible = false;
            this.buscarCodigo.Click += new System.EventHandler(this.buscarCodigo_Click);
            this.buscarCodigo.Paint += new System.Windows.Forms.PaintEventHandler(this.buscarCodigo_Paint);
            // 
            // cadastrarSinistro
            // 
            this.cadastrarSinistro.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cadastrarSinistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(199)))));
            this.cadastrarSinistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cadastrarSinistro.FlatAppearance.BorderSize = 0;
            this.cadastrarSinistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadastrarSinistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cadastrarSinistro.ForeColor = System.Drawing.Color.White;
            this.cadastrarSinistro.Location = new System.Drawing.Point(755, 0);
            this.cadastrarSinistro.Margin = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.cadastrarSinistro.Name = "cadastrarSinistro";
            this.cadastrarSinistro.Size = new System.Drawing.Size(180, 50);
            this.cadastrarSinistro.TabIndex = 12;
            this.cadastrarSinistro.Text = "Cadastrar";
            this.cadastrarSinistro.UseVisualStyleBackColor = false;
            this.cadastrarSinistro.Click += new System.EventHandler(this.cadastrarSinistro_Click);
            this.cadastrarSinistro.Paint += new System.Windows.Forms.PaintEventHandler(this.cadastrarSinistro_Paint);
            // 
            // panel51
            // 
            this.panel51.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel51.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            this.panel51.Controls.Add(this.button10);
            this.panel51.Location = new System.Drawing.Point(8002, 0);
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
            // CadastroSinistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.contentSinistros);
            this.Controls.Add(this.searchPanel);
            this.Name = "CadastroSinistros";
            this.Size = new System.Drawing.Size(975, 385);
            this.Resize += new System.EventHandler(this.CadastroSinistros_Resize);
            this.searchPanel.ResumeLayout(false);
            this.panelSerch.ResumeLayout(false);
            this.panelSerch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.contentSinistros.ResumeLayout(false);
            this.tableSinistro.ResumeLayout(false);
            this.panelCPF.ResumeLayout(false);
            this.SubpanelCPF.ResumeLayout(false);
            this.SubpanelCPF.PerformLayout();
            this.panelNomeClient.ResumeLayout(false);
            this.subpanelNomeClient.ResumeLayout(false);
            this.subpanelNomeClient.PerformLayout();
            this.panelDateTimerClient.ResumeLayout(false);
            this.panelDateTimerClient.PerformLayout();
            this.templatePanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelBorderRounded1.ResumeLayout(false);
            this.panelBorderRounded1.PerformLayout();
            this.panelButton.ResumeLayout(false);
            this.panel51.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel searchPanel;
        private TemplateComponents.PanelBorderRoundedOnLeft panelSerch;
        private PictureBox pictureBox3;
        private Panel contentSinistros;
        private TableLayoutPanel tableSinistro;
        private Panel panelCPF;
        private Panel SubpanelCPF;
        private Label labelCPFClient;
        private Panel panelButton;
        private Panel panel51;
        private Button button10;
        private Button cadastrarSinistro;
        private ComboBox comboTipoSinistro;
        private TemplateComponents.TextBoxOnlyNum_Letters cod;
        private Label typeData;
        private Button buscarCodigo;
        private Panel panelNomeClient;
        private Panel subpanelNomeClient;
        private TemplateComponents.PanelBorderRounded panelDateTimerClient;
        private TemplateComponents.TextBoxOnlyNum_Letters tbDescricaoSinistro;
        private Label labelDescricaoSinistro;
        private TemplateComponents.TemplatePanel templatePanel1;
        private Panel panel1;
        private TemplateComponents.PanelBorderRounded panelBorderRounded1;
        private TemplateComponents.TextBoxOnlyNum tbCod;
        private Label label1;
    }
}
